using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Klijent.User_Controllers;
using Zajednicki.Domen;

namespace Klijent.Controllers
{
    internal class PromeniKupcaController
    {
        ucPromeniKupca ucPromeniKupca;
        Kupac kupac;

        internal Control CreatePromeniKupca(Kupac k)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();


                kupac = k;
                //ucPromeniKupca.CmbMesto.DropDownStyle = ComboBoxStyle.DropDownList;
                ucPromeniKupca = new ucPromeniKupca(kupac);
                ucPromeniKupca.TxtIme.Text = kupac.Ime;
                ucPromeniKupca.TxtPrezime.Text = kupac.Prezime;
                ucPromeniKupca.TxtBrTelefona.Text= kupac.BrTelefona;
                SrediFormu();
                ucPromeniKupca.BtnPromeni.Click += PromeniKupca;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("DEBUG: " + ex.ToString());
            }

            return ucPromeniKupca;
        }

        private void PromeniKupca(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ucPromeniKupca.TxtIme.Text) ||
                string.IsNullOrWhiteSpace(ucPromeniKupca.TxtPrezime.Text) ||
                string.IsNullOrWhiteSpace(ucPromeniKupca.TxtBrTelefona.Text) ||
                ucPromeniKupca.CmbMesto.SelectedIndex == -1)
            {
                MessageBox.Show("Nisu uneta sva polja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Kupac k = new Kupac
                {
                    Ime = ucPromeniKupca.TxtIme.Text,
                    Prezime = ucPromeniKupca.TxtPrezime.Text,
                    BrTelefona = ucPromeniKupca.TxtBrTelefona.Text,
                    Mesto = (Mesto)ucPromeniKupca.CmbMesto.SelectedItem
                };
                try
                {
                    k.Values = $"'{k.Ime}', '{k.Prezime}', '{k.BrTelefona}', {k.Mesto.IdMesto}";
                    k.SelectCondition = $"idKupac = {kupac.IdKupac}";
                    k.Set = $"SET ime = '{k.Ime}', prezime = '{k.Prezime}', brojTelefona = '{k.BrTelefona}', idMesto = {k.Mesto.IdMesto}";
                    DialogResult res = MessageBox.Show("Da li ste sigurni da želite da promenite kupca?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Komunikacija.Instance.AzurirajKupca(k);
                        MessageBox.Show("Sistem je zapamtio promene kupca");

                        MainCoordinator.Instance.ShowPretraziKupca();
                    }
                    else
                    {
                        MessageBox.Show("OK");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne moze da zapamti kupca");


                }
            }
        }

        private void SrediFormu()
        {
            try
            {
                Komunikacija.Instance.PoveziSe();

                List<Mesto> mesta = Komunikacija.Instance.VratiSvaMesta();
                ucPromeniKupca.CmbMesto.DataSource = mesta;
                int br = 0;
                foreach(Mesto mesto in mesta)
                {
                    if (mesto.Naziv == kupac.Mesto.Naziv)
                    {
                        ucPromeniKupca.CmbMesto.SelectedIndex = br;
                        return;
                    }
                    br++;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nije moguce prikazati mesta" + ex, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
