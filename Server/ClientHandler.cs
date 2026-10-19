using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Zajednicki.Komunikacija;
using Zajednicki.Domen;


namespace Server
{
    internal class ClientHandler
    {
        private Socket soket;
        Server server;

        private JsonNetworkSerializer serializer;

        public ClientHandler(Socket soket, Server server)
        {
            this.soket = soket;
            this.server = server;
            serializer = new JsonNetworkSerializer(this.soket);
        }
        public void Handle()
        {
            try
            {

                while (true)
                {
                    Zahtev zahtev = serializer.Receive<Zahtev>();
                    Odgovor odgovor = ProcesuirajZahtev(zahtev);
                    serializer.Send(odgovor);
                }


            }
            catch (IOException ie)
            {
                Debug.Write(">>>>> IE: " + ie.Message);
            }
            catch (SocketException se)
            {
                Debug.Write(">>>>> SE: " + se.Message);
            }
            catch (Exception ex)
            {
                Debug.Write(">>>>> EX: " + ex.Message);
            }
            finally
            {
                if (soket.Connected)
                {
                    soket.Close();
                }
                server.RemoveClient(this);
            }
        }

        internal void CloseSocket()
        {
            soket.Close();
        }

        private Odgovor ProcesuirajZahtev(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Uspesno = true;
            try
            {
                switch(zahtev.Operacija)
                {
                    case Operacija.PrijaviProdavca:
                        odgovor.Objekat = Kontroler.Instance.PrijaviProdavca(serializer.ReadType<Prodavac>(zahtev.Objekat));
                        break;
                    case Operacija.VratiSvaMesta:
                        odgovor.Objekat=Kontroler.Instance.VratiSvaMesta();
                        break;
                    case Operacija.KreirajKupca:
                        Kontroler.Instance.KreirajKupca(serializer.ReadType<Kupac>(zahtev.Objekat));
                        break;
                    case Operacija.PronadjiKupcaPoImenuIPrezimenu:
                        odgovor.Objekat = Kontroler.Instance.PronadjiKupcaPoImenuIPrezimenu(serializer.ReadType<Kupac>(zahtev.Objekat));
                        break;
                    case Operacija.VratiMestoPoId:
                        odgovor.Objekat = Kontroler.Instance.PronadjiMestoPoId(serializer.ReadType<Mesto>(zahtev.Objekat));
                        break;
                    case Operacija.VratiKupcePoMestu:
                        odgovor.Objekat = Kontroler.Instance.VratiListuKupacaPoMestu(serializer.ReadType<Kupac>(zahtev.Objekat));
                        break;
                    case Operacija.PromeniKupca:
                        Kontroler.Instance.PromeniKupca(serializer.ReadType<Kupac>(zahtev.Objekat));
                        break;
                    case Operacija.ObrisiKupca:
                        Kontroler.Instance.ObrisiKupca(serializer.ReadType<Kupac>(zahtev.Objekat));
                        break;
                    case Operacija.DodajStrucnuSpremu:
                        Kontroler.Instance.DodajStrucnuSpremu(serializer.ReadType<StrucnaSprema>(zahtev.Objekat));
                        break;
                    case Operacija.VratiSvePrSS:
                        odgovor.Objekat = Kontroler.Instance.VratiSvePrSS(serializer.ReadType<PrSS>(zahtev.Objekat));
                        break;
                    case Operacija.PronadjiStrucnuSpremu:
                        odgovor.Objekat = Kontroler.Instance.PronadjiStrucnuSpremu(serializer.ReadType<StrucnaSprema>(zahtev.Objekat));
                        break;
                    case Operacija.VratiSveProdavce:
                        odgovor.Objekat = Kontroler.Instance.VratiSveProdavce();
                        break;
                    case Operacija.VratiSveKupce:
                        odgovor.Objekat = Kontroler.Instance.VratiSveKupce();
                        break;
                    case Operacija.VratiSvuSportskuOpremu:
                        odgovor.Objekat = Kontroler.Instance.VratiSvuSportskuOpremu();
                        break;
                    case Operacija.KreirajRacun:
                        Kontroler.Instance.KreirajRacun(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;
                    case Operacija.VratiRacunePoKupcu:
                        odgovor.Objekat = Kontroler.Instance.VratiRacunePoKupcu(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;
                    case Operacija.VratiRacunePoProdavcu:
                        odgovor.Objekat = Kontroler.Instance.VratiRacunePoProdavcu(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;
                    case Operacija.VratiRacunePoDatumu:
                        odgovor.Objekat = Kontroler.Instance.VratiRacunePoDatumu(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;
                    case Operacija.VratiRacunePoIznosu:
                        odgovor.Objekat = Kontroler.Instance.VratiRacunePoIznosu(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;
                    case Operacija.VratiStavkePoIdRacuna:
                        odgovor.Objekat = Kontroler.Instance.VratiStavkePoIdRacuna(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;
                    
                    case Operacija.PromeniRacun:
                        Kontroler.Instance.PromeniRacun(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;

                }

            }catch(Exception ex)
            {
                Debug.WriteLine(">>>>> Greska u ClientHandler: " + ex.Message);

                odgovor.Greska = ex.Message;
                odgovor.Uspesno = false;
            }

            return odgovor;
        }
    }
}
