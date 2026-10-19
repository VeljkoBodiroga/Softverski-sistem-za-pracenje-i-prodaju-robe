using Klijent.User_Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Klijent.Controllers
{

    internal class KreirajRacunController
    {
        ucKreirajRacun ucKreirajRacun;
        StavkaRacuna stavkaR;
        BindingList<StavkaRacuna> listaStavkiRacuna = new BindingList<StavkaRacuna>();
        Racun racun;
        
        internal Control CreateKreirajRacun(Racun r,StavkaRacuna sr)
        {
            ucKreirajRacun=new ucKreirajRacun();
            stavkaR = sr;
            racun = r;
            ucKreirajRacun.DgvStavke.AllowUserToAddRows = false;
            ucKreirajRacun.DgvStavke.RowsAdded += UcitajCenu;

            if (racun == null)
            {
                ucKreirajRacun.Load += UcitajKupce;
                ucKreirajRacun.Load += UcitajProdavce;
            }
            else
            {
                ucKreirajRacun.Load += UcitajRacun;
            }
            ucKreirajRacun.Load += UcitajStavke;

            ucKreirajRacun.DtpDatum.Value = DateTime.Now;
            ucKreirajRacun.DtpDatum.Enabled = false;
            ucKreirajRacun.TxtIznos.Enabled = false;
            ucKreirajRacun.DgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ucKreirajRacun.DgvKupci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ucKreirajRacun.DgvProdavci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ucKreirajRacun.BtnDodajStavku.Click += DodajStavku;
            ucKreirajRacun.BtnKreirajRacun.Click += KreirajRaucn;

            return ucKreirajRacun;
        }

        private void UcitajRacun(object? sender, EventArgs e)
        {
            List<Kupac> lk = new List<Kupac>();
            List<Prodavac> lp = new List<Prodavac>();
            try
            {
                Komunikacija.Instance.PoveziSe();

                lp = Komunikacija.Instance.VratiSveProdavce();
                ucKreirajRacun.DgvProdavci.DataSource = lp;
                foreach (DataGridViewColumn col in ucKreirajRacun.DgvProdavci.Columns)
                {
                    col.Visible = false;
                }

                ucKreirajRacun.DgvProdavci.Columns[1].Visible = true;
                ucKreirajRacun.DgvProdavci.Columns[2].Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati prodavce" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                Komunikacija.Instance.PoveziSe();

                lk = Komunikacija.Instance.VratiSveKupce();
                ucKreirajRacun.DgvKupci.DataSource = lk;

                foreach (DataGridViewColumn col in ucKreirajRacun.DgvKupci.Columns)
                {
                    col.Visible = false;
                }
                ucKreirajRacun.DgvKupci.Columns[1].Visible = true;
                ucKreirajRacun.DgvKupci.Columns[2].Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati kupce" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewRow row in ucKreirajRacun.DgvKupci.Rows)
            {
                if (row.Cells["idKupac"].Value != null &&
                    Convert.ToInt32(row.Cells["idKupac"].Value) == racun.Kupac.IdKupac)
                {
                    row.Selected = true;
                    ucKreirajRacun.DgvKupci.CurrentCell = row.Cells["ime"];
                    break;
                }

            }


            foreach (DataGridViewRow row in ucKreirajRacun.DgvProdavci.Rows)
            {
                if (row.Cells["idProdavac"].Value != null &&
                    Convert.ToInt32(row.Cells["idProdavac"].Value) == racun.Prodavac.IdProdavac)
                {
                    row.Selected = true;
                    ucKreirajRacun.DgvProdavci.CurrentCell = row.Cells["ime"];
                    break;
                }
            }
            ucKreirajRacun.DtpDatum.Value = racun.datum;
            ucKreirajRacun.TxtAdresa.Text = racun.AdresaIzdavanja;
        }

        private void UcitajCenu(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            double cena = 0;

            foreach (StavkaRacuna sr in listaStavkiRacuna)
            {
                cena += sr.CenaStavke;
            }
            ucKreirajRacun.TxtIznos.Text=cena.ToString();
            
        }

        private void UcitajStavke(object? sender, EventArgs e)
        {
            if (stavkaR != null && !listaStavkiRacuna.Contains(stavkaR))
            {
                listaStavkiRacuna.Add(stavkaR);
            }
            ucKreirajRacun.DgvStavke.DataSource = listaStavkiRacuna;
            foreach (DataGridViewColumn col in ucKreirajRacun.DgvStavke.Columns)
            {
                col.Visible = false;
            }

            ucKreirajRacun.DgvStavke.Columns[2].Visible = true;
            ucKreirajRacun.DgvStavke.Columns[3].Visible = true;
            ucKreirajRacun.DgvStavke.Columns[4].Visible = true;

        }

        private void KreirajRaucn(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucKreirajRacun.TxtAdresa.Text) ||
                string.IsNullOrEmpty(ucKreirajRacun.TxtIznos.Text) ||
                ucKreirajRacun.DgvKupci.CurrentRow == null ||
                ucKreirajRacun.DgvProdavci.CurrentRow == null ||
                ucKreirajRacun.DgvStavke.Rows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da zapamti raucn");
            
            }
            else
            {
                Prodavac p=(Prodavac)ucKreirajRacun.DgvProdavci.CurrentRow.DataBoundItem;
                Kupac k = (Kupac)ucKreirajRacun.DgvKupci.CurrentRow.DataBoundItem;
                Racun racun = new Racun
                {
                    Prodavac = p,
                    Kupac = k,
                    AdresaIzdavanja = ucKreirajRacun.TxtAdresa.Text.ToString(),
                    datum = ucKreirajRacun.DtpDatum.Value,
                    Iznos = double.Parse(ucKreirajRacun.TxtIznos.Text),
                    listaStavki=new List<StavkaRacuna>()
                };
                
                try
                {
                    Komunikacija.Instance.PoveziSe();

                    racun.DefaultValues = $"'{racun.datum:yyyy-MM-dd}', {racun.Iznos.ToString(CultureInfo.InvariantCulture)}, '{racun.AdresaIzdavanja}', {racun.Kupac.IdKupac},{racun.Prodavac.IdProdavac}";
                    foreach(StavkaRacuna sr in listaStavkiRacuna)
                    {
                        racun.listaStavki.Add(sr);
                    }
                    Komunikacija.Instance.KreirajRacun(racun);

                    

                    
                    

                    MessageBox.Show("Sistem je kreirao racun");
                    listaStavkiRacuna.Clear();
                    
                    MainCoordinator.Instance.ShowKreirajRacun();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri kreiranju racuna: " + ex.Message);
                }
            }
        }

        private void DodajStavku(object? sender, EventArgs e)
        {
            Prodavac p = (Prodavac)ucKreirajRacun.DgvProdavci.CurrentRow.DataBoundItem;
            Kupac k = (Kupac)ucKreirajRacun.DgvKupci.CurrentRow.DataBoundItem;
            Racun racun = new Racun
            {
                Prodavac = p,
                Kupac = k,
                AdresaIzdavanja = ucKreirajRacun.TxtAdresa.Text.ToString(),
                datum = ucKreirajRacun.DtpDatum.Value,
                
                
            };
            MainCoordinator.Instance.ShowDodajStavkuURacun(racun,stavkaR);

            
            
        }

        private void UcitajProdavce(object? sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();

                ucKreirajRacun.DgvProdavci.DataSource = Komunikacija.Instance.VratiSveProdavce();
                foreach (DataGridViewColumn col in ucKreirajRacun.DgvProdavci.Columns)
                {
                    col.Visible = false;
                }

                ucKreirajRacun.DgvProdavci.Columns[1].Visible = true;
                ucKreirajRacun.DgvProdavci.Columns[2].Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati prodavce" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UcitajKupce(object? sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();

                ucKreirajRacun.DgvKupci.DataSource = Komunikacija.Instance.VratiSveKupce();

                foreach (DataGridViewColumn col in ucKreirajRacun.DgvKupci.Columns)
                {
                    col.Visible = false;
                }
                ucKreirajRacun.DgvKupci.Columns[1].Visible = true;
                ucKreirajRacun.DgvKupci.Columns[2].Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati kupce" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
