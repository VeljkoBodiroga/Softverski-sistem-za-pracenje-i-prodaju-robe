using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent
{
    internal class Komunikacija
    {
        public static Komunikacija instance;

        public static Komunikacija Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Komunikacija();
                }
                return instance;
            }

        }

        private Komunikacija()
        {

        }

        private Socket soket;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private JsonNetworkSerializer serializer;

        public void PoveziSe()
        {
            if (soket == null || !soket.Connected)
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Connect("127.0.0.1", 9999);
                stream = new NetworkStream(soket);
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                serializer = new JsonNetworkSerializer(soket);
            }

        }

        internal Prodavac? PrijaviProdavca(Prodavac p)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.PrijaviProdavca,
                    Objekat = p
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    if (o.Objekat == null)
                    {
                        return null;
                    }
                   
                    Prodavac prijavljeniProdavac = JsonSerializer.Deserialize<Prodavac>(o.Objekat.ToString());
                    return prijavljeniProdavac;
                }
                else
                {
                    
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greška prilikom rada sa serverom!");

            }
        }

        internal List<Mesto> VratiSvaMesta()
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.VratiSvaMesta
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<Mesto> res = JsonSerializer.Deserialize<List<Mesto>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {

                throw new Exception("Greška prilikom rada sa serverom!");
            }

        }

        internal void KreirajKupca(Kupac kupac)
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.KreirajKupca,
                    Objekat = kupac
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {

                throw new Exception("Greška prilikom rada sa serverom!");
            }
        }

        internal Kupac? PronadjiKupcaPoImenuIPrezimenu(Kupac kupac)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.PronadjiKupcaPoImenuIPrezimenu,
                    Objekat = kupac
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {

                    if (o.Objekat == null)
                    {
                        return null;
                    }

                    Kupac pronadjenKupac = JsonSerializer.Deserialize<Kupac>(o.Objekat.ToString());
                    return pronadjenKupac;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        
        internal Mesto PronadjiMestoPoId(Mesto mesto)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiMestoPoId,
                    Objekat = mesto
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    Mesto pronadjenoMesto= JsonSerializer.Deserialize<Mesto>(o.Objekat.ToString());
                    return pronadjenoMesto;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        internal List<Kupac> VratiKupcePoMestu(Kupac pom)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiKupcePoMestu,
                    Objekat = pom
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<Kupac> res = JsonSerializer.Deserialize<List<Kupac>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        internal void AzurirajKupca(Kupac k)
        {
            try
            {
                Zahtev zahtev = new Zahtev() { 
                    Operacija = Operacija.PromeniKupca, 
                    Objekat = k 
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno == false)
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void ObrisiKupca(Kupac kupac)
        {
            try
            {
                Zahtev zahtev = new Zahtev() 
                { 
                    Operacija = Operacija.ObrisiKupca, 
                    Objekat = kupac 
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno == false)
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {
                throw new Exception("Greska!");
            }
        }

        internal void DodajStrucnuSpremu(StrucnaSprema strucnaSprema)
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.DodajStrucnuSpremu,
                    Objekat = strucnaSprema
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {

                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {

                throw new Exception("Greška prilikom rada sa serverom!");
            }
        }

        internal List<PrSS> UcitajListuPrSS(PrSS pom)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiSvePrSS,
                    Objekat = pom
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<PrSS> res = JsonSerializer.Deserialize<List<PrSS>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        internal StrucnaSprema PronadjiStrucnuSpremu(StrucnaSprema pomSS)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.PronadjiStrucnuSpremu,
                    Objekat = pomSS
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    StrucnaSprema ss = JsonSerializer.Deserialize<StrucnaSprema>(o.Objekat.ToString());
                    return ss;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        internal List<Prodavac> VratiSveProdavce()
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.VratiSveProdavce
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<Prodavac> res = JsonSerializer.Deserialize<List<Prodavac>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {

                throw new Exception("Greška prilikom rada sa serverom!");
            }
        }

        internal List<Kupac> VratiSveKupce()
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.VratiSveKupce
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<Kupac> res = JsonSerializer.Deserialize<List<Kupac>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {

                throw new Exception("Greška prilikom rada sa serverom!");
            }
        }

        internal List<SportskaOprema> VratiSvuSportskuOpremu()
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.VratiSvuSportskuOpremu
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<SportskaOprema> res = JsonSerializer.Deserialize<List<SportskaOprema>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {

                throw new Exception("Greška prilikom rada sa serverom!");
            }
        }

        internal void KreirajRacun(Racun racun)
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.KreirajRacun,
                    Objekat = racun
                    

                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>" + se.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)
            {

                throw new Exception("Greška prilikom rada sa serverom!"+ex);
            }
        }

        

        internal List<Racun> VratiRacunePoKupcu(Kupac k)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiRacunePoKupcu,
                    Objekat = k
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<Racun> res = JsonSerializer.Deserialize<List<Racun>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        internal List<Racun> VratiRacunePoProdavcu(Prodavac p)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiRacunePoProdavcu,
                    Objekat = p
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<Racun> res = JsonSerializer.Deserialize<List<Racun>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        internal List<Racun> VratiRacunePoDatumu(Racun r)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiRacunePoDatumu,
                    Objekat = r
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<Racun> res = JsonSerializer.Deserialize<List<Racun>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        internal List<Racun> VratiRacunePoIznosu(Racun r)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiRacunePoIznosu,
                    Objekat = r
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    List<Racun> res = JsonSerializer.Deserialize<List<Racun>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        internal BindingList<StavkaRacuna> VratiStavkePoIdRacuna(Racun r)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiStavkePoIdRacuna,
                    Objekat = r
                };
                if (writer == null || reader == null)
                {
                    throw new Exception("Server nije dostupan!");
                }
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno)
                {
                    BindingList<StavkaRacuna> res = JsonSerializer.Deserialize<BindingList<StavkaRacuna>>(o.Objekat.ToString());
                    return res;
                }
                else
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        

        internal void AzurirajRacun(Racun r)
        {
            try
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.PromeniRacun,
                    Objekat = r
                };
                writer.WriteLine(JsonSerializer.Serialize(zahtev));
                Odgovor o = JsonSerializer.Deserialize<Odgovor>(reader.ReadLine());
                if (o.Uspesno == false)
                {
                    throw new Exception(o.Greska);
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
                throw new Exception("Problem sa serverom!");
            }
            catch (Exception ex)

            {
                Debug.WriteLine(">>>>>" + ex.Message);
                throw new Exception("Greska!");
            }
        }
    }
}
