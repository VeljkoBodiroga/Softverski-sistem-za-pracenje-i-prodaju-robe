
using Klijent.User_Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Klijent.Controllers
{
    internal class LoginController
    {
        ucFrmLoginProdavac ucLoginProdavac;

        internal Control CreateLogIn()
        {
            ucLoginProdavac = new ucFrmLoginProdavac();
            ucLoginProdavac.TxtKorisnickoIme.Text = "bobi";
            ucLoginProdavac.TxtSifra.Text = "123";
            ucLoginProdavac.BtnLogin.Click += Prijava;
            ucLoginProdavac.Load += FrmLogin_Load;


            return ucLoginProdavac;
        }

        private void Prijava(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucLoginProdavac.TxtKorisnickoIme.Text) || string.IsNullOrEmpty(ucLoginProdavac.TxtSifra.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Prodavac p = new Prodavac
                {
                    KorisnikoIme = ucLoginProdavac.TxtKorisnickoIme.Text,
                    Sifra = ucLoginProdavac.TxtSifra.Text
                };

                Prodavac ulogovan = null;

                try
                {
                    Komunikacija.instance.PoveziSe();
                    ulogovan = Komunikacija.instance.PrijaviProdavca(p);
                    if (ulogovan == null)
                    {
                        MessageBox.Show("Korisničko ime i šifra nisu ispravni", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Debug.WriteLine("Ulogovan korisnik>>>>>>>" + ulogovan.ToString());
                        MessageBox.Show($"Korisničko ime i sifra su ispravni, dobrodošli {ulogovan.ToString()}!", "Uspešna prijava", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Form loginForma = ucLoginProdavac.FindForm();

                        MainCoordinator.Instance.ShowMain(ulogovan);

                        
                        if (loginForma != null)
                        {
                            loginForma.Close();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ne može da se otvori glavna forma i meni!\n");
                }

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PoveziSe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesno povezivanje");

            }
        }
    }
}
