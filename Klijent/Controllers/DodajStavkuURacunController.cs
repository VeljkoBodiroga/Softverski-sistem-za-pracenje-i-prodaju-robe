using Klijent.User_Controllers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki.Domen;

namespace Klijent.Controllers
{
    internal class DodajStavkuURacunController
    {
        ucDodajStavkuURacun ucDodajStavkuURacun;
        StavkaRacuna sr;
        Racun racun;

        internal Control CreateDodajStavkuURacun(Racun r,StavkaRacuna stavkaR)
        {
            ucDodajStavkuURacun=new ucDodajStavkuURacun();
            sr = stavkaR;
            racun = r;
            ucDodajStavkuURacun.Load += VratiSvuSportskuOpremu;
            ucDodajStavkuURacun.TxtCena.ReadOnly = true;
            ucDodajStavkuURacun.BtnDodajStavku.Click += DodajStavku;
            ucDodajStavkuURacun.TxtNaziv.Enabled = false;
            
            ucDodajStavkuURacun.DgvSportskaOprema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            return ucDodajStavkuURacun;
        }

        

        internal Control CreateDodajStavkuURacun1(Racun r,StavkaRacuna stavkaR)
        {
            ucDodajStavkuURacun = new ucDodajStavkuURacun();
            sr = stavkaR;
            racun = r;
            ucDodajStavkuURacun.Load += VratiSvuSportskuOpremu;
            ucDodajStavkuURacun.TxtCena.ReadOnly = true;
            ucDodajStavkuURacun.BtnDodajStavku.Click += DodajStavku1;

            ucDodajStavkuURacun.DgvSportskaOprema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            return ucDodajStavkuURacun;
        }

        private void IzracunajCenu(object? sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(ucDodajStavkuURacun.TxtKolicina.Text)|| 
                ucDodajStavkuURacun.DgvSportskaOprema.CurrentRow == null)
            {
            }
            else
            {
                try
                {
                    int? pom = null;
                    pom = int.Parse(ucDodajStavkuURacun.TxtKolicina.Text);
                    if (pom <= 0 || pom == null)
                    {
                        MessageBox.Show("Nije uneta ispravna kolicina");
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Nije uneta ispravna kolicina");
                    return;
                }
                double cena;
                SportskaOprema so = (SportskaOprema)ucDodajStavkuURacun.DgvSportskaOprema.CurrentRow.DataBoundItem;
                
                cena = double.Parse(ucDodajStavkuURacun.TxtKolicina.Text)*so.Cena;
                ucDodajStavkuURacun.TxtCena.Text=cena.ToString();
            }
        }

        private void DodajStavku(object? sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ucDodajStavkuURacun.TxtKolicina.Text)||
                string.IsNullOrEmpty(ucDodajStavkuURacun.TxtCena.Text)||
                string.IsNullOrEmpty(ucDodajStavkuURacun.TxtNaziv.Text)||
                ucDodajStavkuURacun.DgvSportskaOprema.CurrentRow == null)
            {
                MessageBox.Show("Popunite sva polja i izaberite sportsku opremu");
                return;
            }
            else
            {
                try
                {
                    int? pom = null;
                    pom = int.Parse(ucDodajStavkuURacun.TxtKolicina.Text);
                    if (pom <= 0 || pom == null)
                    {
                        MessageBox.Show("Nije uneta ispravna kolicina");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nije uneta ispravna kolicina");
                    return;                }
                try
                {
                    SportskaOprema so = (SportskaOprema)ucDodajStavkuURacun.DgvSportskaOprema.CurrentRow.DataBoundItem;
                    sr = new StavkaRacuna
                    {
                        Naziv = ucDodajStavkuURacun.TxtNaziv.Text,
                        Kolicina = int.Parse(ucDodajStavkuURacun.TxtKolicina.Text),
                        CenaStavke = double.Parse(ucDodajStavkuURacun.TxtCena.Text),
                        idSportskeOpreme = so.IdSportskeOpreme
                    };
                    MainCoordinator.Instance.ShowKreirajRacun(racun,sr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska "+ex);
                    return;
                }
            }
        }


        private void DodajStavku1(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucDodajStavkuURacun.TxtKolicina.Text) ||
                string.IsNullOrEmpty(ucDodajStavkuURacun.TxtCena.Text) ||
                string.IsNullOrEmpty(ucDodajStavkuURacun.TxtNaziv.Text) ||
                ucDodajStavkuURacun.DgvSportskaOprema.CurrentRow == null)
            {
                MessageBox.Show("Popunite sva polja i izaberite sportsku opremu");
                return;
            }
            else
            {
                try
                {
                    int? pom = null;
                    pom = int.Parse(ucDodajStavkuURacun.TxtKolicina.Text);
                    if (pom <= 0 || pom == null)
                    {
                        MessageBox.Show("Nije uneta ispravna kolicina");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nije uneta ispravna kolicina");
                    return;
                }
                try
                {
                    SportskaOprema so = (SportskaOprema)ucDodajStavkuURacun.DgvSportskaOprema.CurrentRow.DataBoundItem;
                    sr = new StavkaRacuna
                    {
                        Naziv = ucDodajStavkuURacun.TxtNaziv.Text,
                        Kolicina = int.Parse(ucDodajStavkuURacun.TxtKolicina.Text),
                        CenaStavke = double.Parse(ucDodajStavkuURacun.TxtCena.Text),
                        idSportskeOpreme = so.IdSportskeOpreme,
                        IdRacun = racun.IdRacun
                    };
                    sr.Values = $"{racun.IdRacun}, '{sr.Naziv}', {sr.Kolicina}, {sr.CenaStavke.ToString(CultureInfo.InvariantCulture)}, {sr.idSportskeOpreme}";
                    MainCoordinator.Instance.ShowPromeniRacun(racun, sr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska"+ex);

                    return;
                }
            }
        }



        private void VratiSvuSportskuOpremu(object? sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();

                ucDodajStavkuURacun.DgvSportskaOprema.DataSource = Komunikacija.Instance.VratiSvuSportskuOpremu();
                foreach (DataGridViewColumn col in ucDodajStavkuURacun.DgvSportskaOprema.Columns)
                {
                    col.Visible = false;
                }

                ucDodajStavkuURacun.DgvSportskaOprema.Columns[1].Visible = true;
                ucDodajStavkuURacun.DgvSportskaOprema.Columns[2].Visible = true;

                ucDodajStavkuURacun.DgvSportskaOprema.SelectionChanged += IzracunajCenu;
                ucDodajStavkuURacun.DgvSportskaOprema.SelectionChanged += UcitajNaziv;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati sportsku opremu" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void UcitajNaziv(object? sender, EventArgs e)
        {
            if (ucDodajStavkuURacun.DgvSportskaOprema.CurrentRow == null)
            {

            }
            else
            {
                SportskaOprema so = (SportskaOprema)ucDodajStavkuURacun.DgvSportskaOprema.CurrentRow.DataBoundItem;
                string pom = so.ToString();
                ucDodajStavkuURacun.TxtNaziv.Text = pom;
            }
        }
    }
}
