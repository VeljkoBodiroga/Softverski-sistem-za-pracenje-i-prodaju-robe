using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Server.Sistemske_operacije;
using System.ComponentModel;

namespace Server
{
    internal class Kontroler
    {
        private static Kontroler instance;
        public static Kontroler Instance
        {
            get
            {
                if (instance == null) instance = new Kontroler();
                return instance;
            }
        }
        private Kontroler()
        {
        }

        internal object PrijaviProdavca(Prodavac prodavac)
        {
            PrijaviProdavcaSO so = new PrijaviProdavcaSO(prodavac);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Mesto> VratiSvaMesta()
        {
            VratiSvaMestaSO so = new VratiSvaMestaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void KreirajKupca(Kupac kupac)
        {
            KreirajKupcaSO so = new KreirajKupcaSO(kupac);
            so.ExecuteTemplate();
        }

        internal object PronadjiKupcaPoImenuIPrezimenu(Kupac kupac)
        {
            PronadjiKupcaPoImenuIPrezimenuSO so = new PronadjiKupcaPoImenuIPrezimenuSO(kupac);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal object PronadjiMestoPoId(Mesto mesto)
        {
            PronadjiMestoPoIdSO so = new PronadjiMestoPoIdSO(mesto);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal object VratiListuKupacaPoMestu(Kupac kupac)
        {
            VratiListuKupacaPoMestuSO so = new VratiListuKupacaPoMestuSO(kupac);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void PromeniKupca(Kupac kupac)
        {
            PromeniKupcaSO so = new PromeniKupcaSO(kupac);
            so.ExecuteTemplate();
        }

        internal void ObrisiKupca(Kupac kupac)
        {
            ObrisiKupcaSO so = new ObrisiKupcaSO(kupac);
            so.ExecuteTemplate();
        }

        internal void DodajStrucnuSpremu(StrucnaSprema strucnaSprema)
        {
            DodajStrucnuSpremuSO so = new DodajStrucnuSpremuSO(strucnaSprema);
            so.ExecuteTemplate();
        }

        internal List<PrSS> VratiSvePrSS(PrSS prSS)
        {
            VratiSvePrSSSO so = new VratiSvePrSSSO(prSS);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal object PronadjiStrucnuSpremu(StrucnaSprema strucnaSprema)
        {
            PronadjiStrucnuSpremuSO so = new PronadjiStrucnuSpremuSO(strucnaSprema);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Prodavac> VratiSveProdavce()
        {
            VratiSveProdavceSO so = new VratiSveProdavceSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Kupac> VratiSveKupce()
        {
            VratiSveKupceSO so = new VratiSveKupceSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<SportskaOprema> VratiSvuSportskuOpremu()
        {
            VratiSvuSportskuOpremuSO so = new VratiSvuSportskuOpremuSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void KreirajRacun(Racun racun)
        {
            KreirajRacunSO so = new KreirajRacunSO(racun);
            so.ExecuteTemplate();
            
        }

        

        internal List<Racun> VratiRacunePoKupcu(Racun racun)
        {
            VratiRacunePoKupcuSO so = new VratiRacunePoKupcuSO(racun);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Racun> VratiRacunePoProdavcu(Racun racun)
        {
            VratiRacunePoProdavcuSO so = new VratiRacunePoProdavcuSO(racun);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal object VratiRacunePoDatumu(Racun racun)
        {
            VratiRacunePoDatumuSO so = new VratiRacunePoDatumuSO(racun);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal object VratiRacunePoIznosu(Racun racun)
        {
            VratiRacunePoIznosuSO so = new VratiRacunePoIznosuSO(racun);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal object VratiStavkePoIdRacuna(Racun racun)
        {
            VratiStavkePoIdRacunaSO so = new VratiStavkePoIdRacunaSO(racun);
            so.ExecuteTemplate();
            return so.Result;
        }

        

        internal void PromeniRacun(Racun racun)
        {
            PromeniRacunSO so = new PromeniRacunSO(racun);
            so.ExecuteTemplate();
        }
    }
}
