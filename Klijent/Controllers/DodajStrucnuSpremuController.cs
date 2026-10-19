using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Klijent.User_Controllers;
using Zajednicki.Domen;
using System.Threading.Tasks;

namespace Klijent.Controllers
{
    internal class DodajStrucnuSpremuController
    {
        ucDodajStrucnuSpremu ucDodajStrucnuSpremu;
        internal Control CreateDodajStrucnuSpremu()
        {
            ucDodajStrucnuSpremu = new ucDodajStrucnuSpremu();
            ucDodajStrucnuSpremu.BtnDodajStrucnuSpremu.Click += DodajStrucnuSpremu;
            return ucDodajStrucnuSpremu;
        }

        private void DodajStrucnuSpremu(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ucDodajStrucnuSpremu.TxtNaziv.Text) ||
                string.IsNullOrWhiteSpace(ucDodajStrucnuSpremu.TxtNivo.Text))
            {
                MessageBox.Show("Nisu uneta sva polja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                StrucnaSprema strucnaSprema = new StrucnaSprema
                {
                    Naziv= ucDodajStrucnuSpremu.TxtNaziv.Text,
                    Nivo=ucDodajStrucnuSpremu.TxtNivo.Text
                };
                try
                {
                    Komunikacija.Instance.PoveziSe();
                    strucnaSprema.Values = $"'{strucnaSprema.Naziv}', '{strucnaSprema.Nivo}'";
                    Komunikacija.Instance.DodajStrucnuSpremu(strucnaSprema);
                    MessageBox.Show("Sistem je kreirao strucnu spremu");
                    ucDodajStrucnuSpremu.TxtNaziv.Text = "";
                    ucDodajStrucnuSpremu.TxtNivo.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne moze da kreira strucnu spremu");


                }
            }
        }
    }
}
