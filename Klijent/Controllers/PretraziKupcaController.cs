using Klijent.User_Controllers;
using Zajednicki.Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Klijent.Controllers
{
    internal class PretraziKupcaController
    {
        ucPretraziKupca ucPretraziKupca;

        internal Control CreatePretraziKupca()
        {
            try
            {
                ucPretraziKupca = new ucPretraziKupca();
                ucPretraziKupca.DgvKupci.ReadOnly = true;
                

                SrediFormu();
                ucPretraziKupca.CmbMesto.DropDownStyle = ComboBoxStyle.DropDownList;
                ucPretraziKupca.BtnPretraziPoImenuIPrezimenu.Click += PretraziPoImenuIPrezimenu;
                ucPretraziKupca.BtnPretraziPoMestu.Click += PretraziPoMestu;
                ucPretraziKupca.BtnPrikazOdabranog.Click += PrikaziOdabranog;
                ucPretraziKupca.BtnObrisi.Click += ZaBrisanje;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska    " + ex);
            }
            return ucPretraziKupca;

        }

        private void ZaBrisanje(object? sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();
                if (ucPretraziKupca.DgvKupci.CurrentRow == null)
                {
                    MessageBox.Show("Odaberite kupca za brizanje!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    try
                    {

                        Kupac kupac = (Kupac)ucPretraziKupca.DgvKupci.CurrentRow.DataBoundItem;
                        kupac.SelectCondition = $"idKupca = {kupac.IdKupac}";
                        List<Racun> racuni = Komunikacija.Instance.VratiRacunePoKupcu(kupac);
                        if (racuni.Count > 0)
                        {
                            MessageBox.Show("Kupac ima izdate račune, ne može se obrisati.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        kupac.SelectCondition = $"idKupac = {kupac.IdKupac}";
                        Komunikacija.Instance.ObrisiKupca(kupac);
                        MessageBox.Show("Sistem je obrisao kupca");
                        MainCoordinator.Instance.ShowPretraziKupca();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Sistem ne moze da obrise kupca\n");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Greska!");
            }
        }

        private void PrikaziOdabranog(object? sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();
                if (ucPretraziKupca.DgvKupci.CurrentRow == null)
                {
                    MessageBox.Show("Odaberite kupca za prikaz!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Kupac kupac = (Kupac)ucPretraziKupca.DgvKupci.CurrentRow.DataBoundItem;
                    MainCoordinator.Instance.ShowPromeniKupca(kupac);
                }

            }
            catch
            {
                MessageBox.Show("Greska!");
            }
        }

        private void PretraziPoMestu(object? sender, EventArgs e)
        {
            if (ucPretraziKupca.CmbMesto.SelectedIndex==-1)
            {
                MessageBox.Show("Niste izabrali mesto po kom cete vrsiti pretragu");
            }
            else
            {
                Mesto mesto=new Mesto();
                mesto = (Mesto)ucPretraziKupca.CmbMesto.SelectedItem;
                Kupac pom = new Kupac
                {
                    Mesto = mesto
                };

                

                try
                {
                    Komunikacija.instance.PoveziSe();
                    string condition = $"idMesto like {mesto.IdMesto}";
                    
                    pom.SelectCondition = condition;
                    pom.Values = "";

                    List<Kupac> listaKupaca = Komunikacija.instance.VratiKupcePoMestu(pom);
                    
                    
                    if (listaKupaca.Count==0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje kupce po zadatim kriterijumima\n", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach(Kupac kupac in listaKupaca)
                        {
                            Mesto pomM = Komunikacija.instance.PronadjiMestoPoId(kupac.Mesto);
                            kupac.Mesto = pomM;
                        }

                        ucPretraziKupca.DgvKupci.DataSource = listaKupaca;

                        foreach (DataGridViewColumn col in ucPretraziKupca.DgvKupci.Columns)
                        {
                            col.Visible = false;
                        }
                        
                        ucPretraziKupca.DgvKupci.Columns[1].Visible = true;
                        ucPretraziKupca.DgvKupci.Columns[2].Visible = true;
                        ucPretraziKupca.DgvKupci.Columns[4].Visible = true;
                        MessageBox.Show("Sistem je nasao kupce po zadatim kriterijumima");
                        ucPretraziKupca.DgvKupci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Sistem ne moze da nadje kupce po zadatim kriterijumima\n");
                }
            }
        }

        private void PretraziPoImenuIPrezimenu(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucPretraziKupca.TxtImePrezime.Text))
            {
                MessageBox.Show("Niste uneli ime i prezime za pretragu");
            }
            else
            {
                Kupac kupac = new Kupac();
                string[] delovi = ucPretraziKupca.TxtImePrezime.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (delovi.Length < 2)
                {
                    MessageBox.Show("Unesite i ime i prezime (odvojene razmakom)");
                    return;
                }
                string ime = delovi[0] != null ? delovi[0] : "";
                string prezime= delovi[1];
                kupac = new Kupac {
                    Ime = char.ToUpper(ime[0]) + ime.Substring(1),
                    Prezime = char.ToUpper(prezime[0])+prezime.Substring(1)
                };


                Kupac pronadjen= null;

                try
                {
                    Komunikacija.instance.PoveziSe();
                    string condition = $" ime like '{kupac.Ime}%' and prezime like '{kupac.Prezime}%'";
                    
                    kupac.SelectCondition = condition;
                    kupac.Values = "";

                    
                    pronadjen = Komunikacija.instance.PronadjiKupcaPoImenuIPrezimenu(kupac);
                    
                    if (pronadjen == null)
                    {
                        MessageBox.Show("Sistem ne moze da nadje kupce po zadatim kriterijumima\n", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Mesto pom = Komunikacija.instance.PronadjiMestoPoId(pronadjen.Mesto);
                        pronadjen.Mesto = pom;
                        ucPretraziKupca.DgvKupci.DataSource = new List<Kupac> { pronadjen }; ;
                        foreach (DataGridViewColumn col in ucPretraziKupca.DgvKupci.Columns)
                        {
                            col.Visible = false;
                        }
                        //MessageBox.Show(pronadjen.Mesto.IdMesto.ToString());
                        ucPretraziKupca.DgvKupci.Columns[1].Visible = true;
                        ucPretraziKupca.DgvKupci.Columns[2].Visible = true;
                        ucPretraziKupca.DgvKupci.Columns[4].Visible = true;
                        
                        ucPretraziKupca.DgvKupci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        MessageBox.Show("Sistem je nasao kupce po zadatim kriterijumima");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Sistem ne moze da nadje kupce po zadatim kriterijumima\n");
                }

            }
        }

        


        private void SrediFormu()
        {
            try
            {
                Komunikacija.Instance.PoveziSe();

                ucPretraziKupca.CmbMesto.DataSource = Komunikacija.Instance.VratiSvaMesta();
                ucPretraziKupca.CmbMesto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati mesta" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
