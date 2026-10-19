using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klijent.User_Controllers;
using Zajednicki.Domen;

namespace Klijent.Controllers
{
    internal class KreirajKupcaController
    {
        ucKreirajKupca ucKreirajKupca;
        internal Control CreateKreirajKupca()
        {
            ucKreirajKupca=new ucKreirajKupca();

            SrediFormu();
            ucKreirajKupca.CmbMesto.DropDownStyle= ComboBoxStyle.DropDownList;
            ucKreirajKupca.BtnKreirajKupca.Click += KreirajKupca;
            return ucKreirajKupca;
        }

        private void KreirajKupca(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ucKreirajKupca.TxtIme.Text) ||
                string.IsNullOrWhiteSpace(ucKreirajKupca.TxtPrezime.Text) ||
                string.IsNullOrWhiteSpace(ucKreirajKupca.TxtBrojTelefona.Text) ||
                ucKreirajKupca.CmbMesto.SelectedIndex == -1)
            {
                MessageBox.Show("Nisu uneta sva polja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Kupac kupac = new Kupac
                {
                    Ime = ucKreirajKupca.TxtIme.Text,
                    Prezime = ucKreirajKupca.TxtPrezime.Text,
                    BrTelefona = ucKreirajKupca.TxtBrojTelefona.Text,
                    Mesto = (Mesto)ucKreirajKupca.CmbMesto.SelectedItem
                };
                try
                {
                    Komunikacija.Instance.PoveziSe();
                    kupac.Values = $"'{kupac.Ime}', '{kupac.Prezime}', '{kupac.BrTelefona}', {kupac.Mesto.IdMesto}";
                    Komunikacija.Instance.KreirajKupca(kupac);
                    MessageBox.Show("Sistem je sacuvao kupca");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne moze da kreira kupca");


                }
            }

        }

        

        private void SrediFormu()
        {
            try
            {
                Komunikacija.Instance.PoveziSe();
                
                ucKreirajKupca.CmbMesto.DataSource = Komunikacija.Instance.VratiSvaMesta();
                ucKreirajKupca.CmbMesto.SelectedIndex = -1;
            }
            catch (Exception ex )
            {

                MessageBox.Show("Nije moguce prikazati mesta" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
