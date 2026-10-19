using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Klijent.Controllers
{
    internal class MainCoordinator
    {
        private Glavna frmGlavna;
        private FrmLogin frmLogin;

        private LoginController loginController;
        private PrijavljenProdavacController prijavljenProdavacController;
        private KreirajKupcaController kreirajKupcaController;
        private PretraziKupcaController pretraziKupcaController;
        private PromeniKupcaController promeniKupcaController;
        private DodajStrucnuSpremuController dodajStrucnuSpremuController;
        private KreirajRacunController kreirajRacunController;
        private DodajStavkuURacunController dodajStavkuURacunController;
        private PretraziRacunController pretraziRacunController;
        private PrikaziListuRacunaController prikaziListuRacunaController;
        private PromeniRacunController promeniRacunController;
        private PrikaziMestaController prikaziMestaController;
        private PrikazSportskihOpremaController prikazSportskihOprema;

        private static MainCoordinator instance;

        public static MainCoordinator Instance
        {
            get {  
                if(instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        private MainCoordinator()
        {
            loginController = new LoginController();
            prijavljenProdavacController = new PrijavljenProdavacController();
            kreirajKupcaController=new KreirajKupcaController();
            pretraziKupcaController=new PretraziKupcaController();
            promeniKupcaController = new PromeniKupcaController();
            dodajStrucnuSpremuController= new DodajStrucnuSpremuController();
            kreirajRacunController=new KreirajRacunController();
            dodajStavkuURacunController= new DodajStavkuURacunController();
            pretraziRacunController = new PretraziRacunController();
            prikaziListuRacunaController= new PrikaziListuRacunaController();
            promeniRacunController = new PromeniRacunController();
            prikaziMestaController = new PrikaziMestaController();
            prikazSportskihOprema = new PrikazSportskihOpremaController();
        }

        

        internal void ShowMain(Prodavac p)
        {
            frmGlavna = new Glavna(p);
            frmGlavna.AutoSize=true;
            Debug.WriteLine("GLAVNA KREIRANA");
            frmGlavna.ShowDialog();
        }


        //LOGIN
        internal void ShowLogIn()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            Application.Run(frmLogin);
        }
        internal void ShowLogInControl()
        {
            frmLogin.ChangePanel(loginController.CreateLogIn());
        }


        //Glavna
        internal void ShowPrijavljeniProdavac(Prodavac p)
        {
            frmGlavna.ChangePanel(prijavljenProdavacController.CreatePrijavljenProdavac(p));
        }

        internal void ShowKreirajKupca()
        {
            frmGlavna.ChangePanel(kreirajKupcaController.CreateKreirajKupca());
        }

        internal void ShowPretraziKupca()
        {
            frmGlavna.ChangePanel(pretraziKupcaController.CreatePretraziKupca());
        }

        internal void ShowPromeniKupca(Kupac kupac)
        {
            frmGlavna.ChangePanel(promeniKupcaController.CreatePromeniKupca(kupac));
        }


        internal void ShowDodajStrucnuSpremu()
        {
            frmGlavna.ChangePanel(dodajStrucnuSpremuController.CreateDodajStrucnuSpremu());
        }

        internal void ShowKreirajRacun(Racun r=null,StavkaRacuna sr=null)
        {
            frmGlavna.ChangePanel(kreirajRacunController.CreateKreirajRacun(r,sr));
        }

        internal void ShowDodajStavkuURacun(Racun r,StavkaRacuna stavkaR)
        {
            frmGlavna.ChangePanel(dodajStavkuURacunController.CreateDodajStavkuURacun(r,stavkaR));
        }

        internal void ShowPretraziRacun()
        {
            frmGlavna.ChangePanel(pretraziRacunController.CreatePretraziRacun());
        }

        internal void ShowPrikaziListuRacuna(List<Racun> listaRacuna)
        {
            frmGlavna.ChangePanel(prikaziListuRacunaController.CreatePrikaziRacune(listaRacuna));
        }

        internal void ShowPromeniRacun(Racun racun,StavkaRacuna sr=null)
        {
            frmGlavna.ChangePanel(promeniRacunController.CreatePromeniRacun(racun,sr));
        }

        internal void ShowDodajStavkuURacun1(Racun r, StavkaRacuna stavkaR)
        {
            frmGlavna.ChangePanel(dodajStavkuURacunController.CreateDodajStavkuURacun1(r, stavkaR));
        }

        internal void ShowMesta()
        {
            frmGlavna.ChangePanel(prikaziMestaController.CreatePrikaziMesta());
        }

        internal void ShowSportskaOprema()
        {
            frmGlavna.ChangePanel(prikazSportskihOprema.CreatePrikaziSportskeOpreme());
           }
    }
}
