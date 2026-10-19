using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klijent.User_Controllers;
using Zajednicki.Domen;

namespace Klijent.Controllers
{
    internal class PretraziRacunController
    {
        ucPretraziRacun ucPretraziRacun;
        int pretraga;
        List<Racun> listaRacuna=new List<Racun>();
        internal Control CreatePretraziRacun()
        {
            ucPretraziRacun = new ucPretraziRacun();

            ucPretraziRacun.CmbZnak.Items.Add("=");
            ucPretraziRacun.CmbZnak.Items.Add(">");
            ucPretraziRacun.CmbZnak.Items.Add("<");
            ucPretraziRacun.CmbZnak.Items.Add(">=");
            ucPretraziRacun.CmbZnak.Items.Add("<=");
            ucPretraziRacun.CmbZnak.SelectedIndex = -1;
            ucPretraziRacun.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ucPretraziRacun.DataGridView1.AllowUserToAddRows = false;
            ucPretraziRacun.BtnPretragaPoKupcu.Click += PretragaPoKupcu;
            ucPretraziRacun.BtnPretragaPoProdavcu.Click += PretragaPoProdavcu;
            ucPretraziRacun.BtnPretraziPoDatumu.Click += PretragaPoDatumu;
            ucPretraziRacun.BtnPretraziPoIznosu.Click += PretragaPoIznosu;
            ucPretraziRacun.BtnPrikazKupaca.Click += PrikaziKupce;
            ucPretraziRacun.BtnPrikazProdavaca.Click += PrikaziProdavce;

            return ucPretraziRacun;
        }

        private void PretragaPoKupcu(object? sender, EventArgs e)
        {
            if (ucPretraziRacun.DataGridView1.CurrentRow == null ||
                pretraga == 1)
            {
                MessageBox.Show("Prikazani su prodavci ili niste selektovali kupca");

            }
            else {
                

                try
                {
                    Kupac k = (Kupac)ucPretraziRacun.DataGridView1.CurrentRow.DataBoundItem;
                    Komunikacija.instance.PoveziSe();
                    string condition = $"idKupca like {k.IdKupac}";

                    k.SelectCondition = condition;
                    k.Values = "";

                    List<Racun> listaRacuna = Komunikacija.instance.VratiRacunePoKupcu(k);


                    if (listaRacuna.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje kupca po zadatim kriterijumima\n", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Sistem je nasao racune po zadatim kriterijumima");

                        MainCoordinator.Instance.ShowPrikaziListuRacuna(listaRacuna);
                        //ucPretraziRacun.DataGridView1.DataSource = listaRacuna;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Sistem ne moze da nadje kupca po zadatim kriterijumima\n" + ex);
                }
            }
        }

        private void PretragaPoProdavcu(object? sender, EventArgs e)
        {
            if (ucPretraziRacun.DataGridView1.CurrentRow == null ||
               pretraga == 2)
            {
                MessageBox.Show("Prikazani su prodavci ili niste selektovali prodavca");

            }
            else
            {


                try
                {
                    Prodavac p = (Prodavac)ucPretraziRacun.DataGridView1.CurrentRow.DataBoundItem;
                    Komunikacija.instance.PoveziSe();
                    string condition = $"idProdavca like {p.IdProdavac}";

                    p.SelectCondition = condition;
                    p.Values = "";

                    List<Racun> listaRacuna = Komunikacija.instance.VratiRacunePoProdavcu(p);


                    if (listaRacuna.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje kupca po zadatim kriterijumima\n", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Prikazi ga u novoj formi
                        MessageBox.Show("Sistem je nasao racune po zadatim kriterijumima");

                        MainCoordinator.Instance.ShowPrikaziListuRacuna(listaRacuna);
                        //ucPretraziRacun.DataGridView1.DataSource = listaRacuna;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Sistem ne moze da nadje kupca po zadatim kriterijumima\n" + ex);
                }
            }
        }

        private void PretragaPoDatumu(object? sender, EventArgs e)
        {
            try
            {
                DateTime datum1 = ucPretraziRacun.DtpDatum.Value;
                Racun r = new Racun { datum=datum1};
                
                Komunikacija.instance.PoveziSe();
                string condition = $"datum = '{r.datum:yyyy-MM-dd}'";

                r.SelectCondition = condition;
                r.Values = "";

                List<Racun> listaRacuna = Komunikacija.instance.VratiRacunePoDatumu(r);


                if (listaRacuna.Count == 0)
                {
                    MessageBox.Show("Sistem ne moze da nadje kupca po zadatim kriterijumima\n", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Prikazi ga u novoj formi
                    MessageBox.Show("Sistem je nasao racune po zadatim kriterijumima");
                    MainCoordinator.Instance.ShowPrikaziListuRacuna(listaRacuna);
                    //ucPretraziRacun.DataGridView1.DataSource = listaRacuna;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sistem ne moze da nadje kupca po zadatim kriterijumima\n" + ex);
            }



        }


        private void PretragaPoIznosu(object? sender, EventArgs e)
        {
            if(ucPretraziRacun.CmbZnak.SelectedIndex == -1||
                string.IsNullOrEmpty(ucPretraziRacun.TxtIznos.Text))
            {
                MessageBox.Show("Unesite sve potrebno za pretragu po iznosu");
            }
            else
            {
                double? pom = null;
                pom = double.Parse(ucPretraziRacun.TxtIznos.Text);
                if (pom <= 0)
                {
                    MessageBox.Show("Nije unet ispravan iznos");
                    return;
                }
                try
                {
                    Komunikacija.instance.PoveziSe();
                    string condition;
                    Racun r = new Racun { Iznos = double.Parse(ucPretraziRacun.TxtIznos.Text) };

                    switch (ucPretraziRacun.CmbZnak.SelectedItem.ToString()) {
                        case "=":
                            condition = $"iznos = {r.Iznos}";
                            break;
                        case ">=":
                            condition = $"iznos >= {r.Iznos}";
                            break;
                        case "<=":
                            condition = $"iznos <= {r.Iznos}";
                            break;
                        case "<":
                            condition = $"iznos < {r.Iznos}";
                            break;
                        case ">":
                            condition = $"iznos >{r.Iznos}";
                            break;
                        default:
                            condition = "";
                            break;
                            

                    }
                    
                    r.SelectCondition = condition;
                    
                        List<Racun> listaRacuna = Komunikacija.Instance.VratiRacunePoIznosu(r);


                        if (listaRacuna.Count == 0)
                        {

                            MessageBox.Show("Sistem ne moze da nadje kupca po zadatim kriterijumima\n", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Sistem je nasao racune po zadatim kriterijumima");

                            MainCoordinator.Instance.ShowPrikaziListuRacuna(listaRacuna);
                            //ucPretraziRacun.DataGridView1.DataSource = listaRacuna;

                        }

                    }
                
                catch (Exception ex)
                {

                    MessageBox.Show("Sistem ne moze da nadje kupca po zadatim kriterijumima\n" + ex);
                }
            }
        }

        private void PrikaziProdavce(object? sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();

                ucPretraziRacun.DataGridView1.DataSource = Komunikacija.Instance.VratiSveProdavce();
                foreach (DataGridViewColumn col in ucPretraziRacun.DataGridView1.Columns)
                {
                    col.Visible = false;
                }

                ucPretraziRacun.DataGridView1.Columns[1].Visible = true;
                ucPretraziRacun.DataGridView1.Columns[2].Visible = true;
                ucPretraziRacun.BtnPrikazProdavaca.Enabled = false;
                ucPretraziRacun.BtnPrikazKupaca.Enabled = true;
                pretraga = 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati mesta" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrikaziKupce(object? sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();

                ucPretraziRacun.DataGridView1.DataSource = Komunikacija.Instance.VratiSveKupce();

                foreach (DataGridViewColumn col in ucPretraziRacun.DataGridView1.Columns)
                {
                    col.Visible = false;
                }
                ucPretraziRacun.DataGridView1.Columns[1].Visible = true;
                ucPretraziRacun.DataGridView1.Columns[2].Visible = true;
                ucPretraziRacun.BtnPrikazKupaca.Enabled = false;
                ucPretraziRacun.BtnPrikazProdavaca.Enabled = true;
                pretraga = 2;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati mesta" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
