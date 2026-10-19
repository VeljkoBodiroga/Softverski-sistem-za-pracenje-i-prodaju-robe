using Klijent.User_Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Klijent.Controllers
{
    internal class PrijavljenProdavacController

    {

        ucPrijavljeniProdavac ucPrijavljeniProdavac;
        Prodavac prodavac;

        internal Control CreatePrijavljenProdavac(Prodavac p)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();


                prodavac = p;
                ucPrijavljeniProdavac = new ucPrijavljeniProdavac(prodavac);
                ucPrijavljeniProdavac.TxtIme.Text = prodavac.Ime;
                ucPrijavljeniProdavac.TxtPrezime.Text = prodavac.Prezime;
                ucPrijavljeniProdavac.Load += UcitajStrucneSpremeProdavca;
                ucPrijavljeniProdavac.TxtIme.Enabled = false;
                ucPrijavljeniProdavac.TxtPrezime.Enabled = false;

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati prodavca"+ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ucPrijavljeniProdavac;

        }

        private void UcitajStrucneSpremeProdavca(object? sender, EventArgs e)
        {
            PrSS pom=new PrSS();
            try
            {
                Komunikacija.instance.PoveziSe();
                string condition = $"idProdavac like {prodavac.IdProdavac}";

                pom.SelectCondition = condition;
                pom.Values = "";

                List<PrSS> listaPrSS = Komunikacija.instance.UcitajListuPrSS(pom);


                if (listaPrSS.Count == 0)
                {
                    MessageBox.Show("Ne postoji takav u bazi", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<StrucnaSprema> listaStrucnihSprema=new List<StrucnaSprema>();
                    List<DateTime> listaDatuma=new List<DateTime>();
                    foreach (PrSS p in listaPrSS) {
                        StrucnaSprema pomSS = new StrucnaSprema {
                            IdStrucnaSprema=p.IdStrucnaSprema
                        };
                        string condition1 = $"idStrucnaSprema = {p.IdStrucnaSprema}";
                        pomSS.SelectCondition = condition1;
                        listaStrucnihSprema.Add(Komunikacija.Instance.PronadjiStrucnuSpremu(pomSS));
                        listaDatuma.Add(p.DatumIzdavanja);
                    }

                    var spojenaLista = listaStrucnihSprema
                         .Zip(listaDatuma, (ss, datum) => new
                         {
                             Naziv = ss.Naziv,
                             Nivo = ss.Nivo,
                             DatumIzdavanja = datum.ToString("dd.MM.yyyy.")
                            }).ToList();
                    ucPrijavljeniProdavac.DgvStrucneSpreme.DataSource = spojenaLista;

                    //foreach (DataGridViewColumn col in ucPrijavljeniProdavac.DgvStrucneSpreme.Columns)
                    //{
                    //    col.Visible = false;
                    //}
                    //ucPrijavljeniProdavac.DgvStrucneSpreme.Columns[0].Visible = true;
                    //ucPrijavljeniProdavac.DgvStrucneSpreme.Columns[1].Visible = true;
                    //ucPrijavljeniProdavac.DgvStrucneSpreme.Columns[2].Visible = true;


                    ucPrijavljeniProdavac.DgvStrucneSpreme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ne može da se pronadje kupac\n" + ex);
            }
        }
    }
}
