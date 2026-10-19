using Klijent.User_Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;


namespace Klijent.Controllers
{
    internal class PromeniRacunController
    {
        ucPromeniRacun ucPromeniRacun;
        Racun r;
        Kupac k;Prodavac p;
        BindingList<StavkaRacuna> listaStavkiRacuna = new BindingList<StavkaRacuna>();
        StavkaRacuna stavkaR;
        BindingList<StavkaRacuna> listaDodatihStavki = new BindingList<StavkaRacuna>();
        BindingList<StavkaRacuna> listaObrisanihStavki = new BindingList<StavkaRacuna>();
        BindingList<StavkaRacuna> konacnaListaStavki= new BindingList<StavkaRacuna>();
        

        internal Control CreatePromeniRacun(Racun racun,StavkaRacuna sr)
        {
            int? staraId = r?.IdRacun;
            r = racun;
            stavkaR= sr;
            ucPromeniRacun = new ucPromeniRacun();

            if (staraId == null || staraId != racun.IdRacun)
            {
                listaDodatihStavki.Clear();
                listaObrisanihStavki.Clear();
            }
            ucPromeniRacun.DtpDatum.Value=DateTime.Now;
            UcitajRacun();
            VratiStavkeRacunaPoIdRacuna(r,stavkaR);
            ucPromeniRacun.DgvProdavci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ucPromeniRacun.DgvKupci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ucPromeniRacun.DgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ucPromeniRacun.DgvStavke.RowsAdded += UcitajCenu;
            ucPromeniRacun.DgvStavke.RowsRemoved += UcitajCenu1;
            ucPromeniRacun.BtnDodajStavku.Click += DodajStavku;
            ucPromeniRacun.BtnObrisiStavku.Click += ObrisiStavku;
            ucPromeniRacun.BtnPromeniRacun.Click += PromeniRacun;

            

            return ucPromeniRacun;
        }

        private void UcitajCenu1(object? sender, DataGridViewRowsRemovedEventArgs e)
        {
            double cena = 0;

            foreach (StavkaRacuna sr in listaStavkiRacuna)
            {
                cena += sr.CenaStavke;
            }
            ucPromeniRacun.TxtIznos.Text = cena.ToString();
        }

        private void UcitajCenu(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            double cena = 0;

            foreach (StavkaRacuna sr in listaStavkiRacuna)
            {
                cena += sr.CenaStavke;
            }
            ucPromeniRacun.TxtIznos.Text = cena.ToString();
        }

        private void PromeniRacun(object? sender, EventArgs e)
        {
            try
            {
                 k = (Kupac)ucPromeniRacun.DgvKupci.CurrentRow.DataBoundItem;
                p = (Prodavac)ucPromeniRacun.DgvProdavci.CurrentRow.DataBoundItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate izabrati kupca i/ili prodavca" + ex);
                return;
            }
            
            if (k.IdKupac == r.Kupac.IdKupac && p.IdProdavac==r.Prodavac.IdProdavac &&
                ucPromeniRacun.TxtAdresa.Text.Equals(r.AdresaIzdavanja) && 
                ucPromeniRacun.DtpDatum.Value.Equals(r.datum) && 
                listaObrisanihStavki.Count==0 && listaDodatihStavki.Count==0)
            {
                MessageBox.Show("Morate nesto promeniti da biste promenili racun");
            }
            else
            {
                try
                {


                    Racun noviRacun = new Racun
                    {
                        Prodavac = p,
                        Kupac = k,
                        AdresaIzdavanja = ucPromeniRacun.TxtAdresa.Text,
                        Iznos = double.Parse(ucPromeniRacun.TxtIznos.Text, CultureInfo.InvariantCulture), 
                        datum = ucPromeniRacun.DtpDatum.Value,   
                        IdRacun = r.IdRacun,
                        listaStavki = new List<StavkaRacuna>()
                    };
                    Komunikacija.Instance.PoveziSe();
                    foreach(StavkaRacuna sr in listaStavkiRacuna)
                    {
                        if (listaDodatihStavki.Contains(sr))
                        {
                            sr.zaDodavanje = true;
                        }
                        konacnaListaStavki.Add(sr);
                    }
                    foreach(StavkaRacuna sr in listaObrisanihStavki)
                    {
                        sr.zaBrisanje = true;
                        konacnaListaStavki.Add(sr);
                    }
                    foreach(StavkaRacuna sr in konacnaListaStavki)
                    {
                        noviRacun.listaStavki.Add(sr);
                    }

                    noviRacun.Values = $"'{noviRacun.datum}', {noviRacun.Iznos}, '{noviRacun.AdresaIzdavanja}', {noviRacun.Kupac.IdKupac}, {noviRacun.Prodavac.IdProdavac}";
                    noviRacun.SelectCondition = $"idRacun = {noviRacun.IdRacun}";
                    noviRacun.Set = $"SET datum = '{noviRacun.datum:yyyy-MM-dd}', iznos = '{noviRacun.Iznos}', adresaIzdavanja = '{noviRacun.AdresaIzdavanja}', idKupca = {noviRacun.Kupac.IdKupac}, idProdavca = {noviRacun.Prodavac.IdProdavac}";
                    DialogResult res = MessageBox.Show("Da li ste sigurni da želite da promenite evidenciju nastave?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    


                    if (res == DialogResult.Yes)
                    {
                        Komunikacija.Instance.AzurirajRacun(noviRacun);
                        
                            
                        
                        MessageBox.Show("Sistem je zapamtio promene racuna");

                        MainCoordinator.Instance.ShowPretraziRacun();
                    }
                    else
                    {
                        MessageBox.Show("OK");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Sistem ne moze da zapamti racun", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ObrisiStavku(object? sender, EventArgs e)
        {
            if (ucPromeniRacun.DgvStavke.CurrentRow != null)
            {
                StavkaRacuna obrisana = (StavkaRacuna)ucPromeniRacun.DgvStavke.CurrentRow.DataBoundItem;

                
                if (listaDodatihStavki.Contains(obrisana))
                {
                    listaDodatihStavki.Remove(obrisana);
                }
                else
                {
                    listaObrisanihStavki.Add(obrisana);
                }

                listaStavkiRacuna.Remove(obrisana);
            }
            else
            {
                MessageBox.Show("Izaberite stavku za brisanje");
            }
        }

        private void DodajStavku(object? sender, EventArgs e)
        {
            Racun promenjenRacun;
            try
            {
               
                promenjenRacun = new Racun
                {
                    Prodavac = (Prodavac)ucPromeniRacun.DgvProdavci.CurrentRow.DataBoundItem,
                    Kupac = (Kupac)ucPromeniRacun.DgvKupci.CurrentRow.DataBoundItem,
                    AdresaIzdavanja = ucPromeniRacun.TxtAdresa.Text,
                    Iznos = double.Parse(ucPromeniRacun.TxtIznos.Text, CultureInfo.InvariantCulture),
                    datum = ucPromeniRacun.DtpDatum.Value,
                    IdRacun = r.IdRacun
                };
            }
            catch (Exception ex)
            {
                return;
            }
            MainCoordinator.Instance.ShowDodajStavkuURacun1(promenjenRacun,stavkaR);
        }

        private void UcitajRacun()
        {
            List<Kupac> lk = new List<Kupac>();
            List<Prodavac> lp = new List<Prodavac>();
            try
            {
                Komunikacija.Instance.PoveziSe();

                lp = Komunikacija.Instance.VratiSveProdavce();
                ucPromeniRacun.DgvProdavci.DataSource = lp;
                foreach (DataGridViewColumn col in ucPromeniRacun.DgvProdavci.Columns)
                {
                    col.Visible = false;
                }

                ucPromeniRacun.DgvProdavci.Columns[1].Visible = true;
                ucPromeniRacun.DgvProdavci.Columns[2].Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati prodavce" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                Komunikacija.Instance.PoveziSe();

                lk = Komunikacija.Instance.VratiSveKupce();
                ucPromeniRacun.DgvKupci.DataSource = lk;

                foreach (DataGridViewColumn col in ucPromeniRacun.DgvKupci.Columns)
                {
                    col.Visible = false;
                }
                ucPromeniRacun.DgvKupci.Columns[1].Visible = true;
                ucPromeniRacun.DgvKupci.Columns[2].Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati kupce" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewRow row in ucPromeniRacun.DgvKupci.Rows)
            {
                if (row.Cells["idKupac"].Value != null &&
                    Convert.ToInt32(row.Cells["idKupac"].Value) == r.Kupac.IdKupac)
                {
                    row.Selected = true;
                    ucPromeniRacun.DgvKupci.CurrentCell = row.Cells["ime"];
                    break;
                }

            }


            foreach (DataGridViewRow row in ucPromeniRacun.DgvProdavci.Rows)
            {
                if (row.Cells["idProdavac"].Value != null &&
                    Convert.ToInt32(row.Cells["idProdavac"].Value) == r.Prodavac.IdProdavac)
                {
                    row.Selected = true;
                    ucPromeniRacun.DgvProdavci.CurrentCell = row.Cells["ime"];
                    break;
                }
            }



            ucPromeniRacun.TxtAdresa.Text = r.AdresaIzdavanja;
            ucPromeniRacun.TxtIznos.Enabled = false;
            ucPromeniRacun.TxtIznos.Text = r.Iznos.ToString();
            ucPromeniRacun.DtpDatum.Value = r.datum;



            
        }

        private void VratiStavkeRacunaPoIdRacuna(Racun r,StavkaRacuna sr)
        {

            try
            {
                
                Komunikacija.Instance.PoveziSe();

                if (listaStavkiRacuna.Count == 0 || !listaStavkiRacuna.Any(x => x.IdRacun == r.IdRacun))
                {
                    r.SelectCondition = $"idRacun like {r.IdRacun}";
                    listaStavkiRacuna = Komunikacija.Instance.VratiStavkePoIdRacuna(r);

                    foreach (var vec in listaDodatihStavki)
                        if (!listaStavkiRacuna.Contains(vec))
                            listaStavkiRacuna.Add(vec);

                    foreach (var obr in listaObrisanihStavki)
                        if (listaStavkiRacuna.Contains(obr))
                            listaStavkiRacuna.Remove(obr);
                }
                if (sr != null && !listaStavkiRacuna.Contains(sr)&& sr.Kolicina!=0)
                {
                    listaStavkiRacuna.Add(stavkaR);
                    listaDodatihStavki.Add(stavkaR);
                }


                ucPromeniRacun.DgvStavke.DataSource = listaStavkiRacuna;
                foreach (DataGridViewColumn col in ucPromeniRacun.DgvStavke.Columns)
                {
                    col.Visible = false;
                }
                ucPromeniRacun.DgvStavke.Columns[2].Visible = true;
                ucPromeniRacun.DgvStavke.Columns[3].Visible = true;
                ucPromeniRacun.DgvStavke.Columns[4].Visible = true;
                ucPromeniRacun.DgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ucPromeniRacun.DgvStavke.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Greska!" + ex);
                }

            }
        }
    }
}
