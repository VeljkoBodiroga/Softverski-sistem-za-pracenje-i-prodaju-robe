using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Racun :IEntity
    {
        public int IdRacun { get; set; }
        public DateTime datum {  get; set; }
        public double Iznos { get; set; } //zbir svih stavki
        public string AdresaIzdavanja { get; set; }
        public Kupac Kupac {  get; set; }
        public Prodavac Prodavac {  get; set; }

        public List<StavkaRacuna> listaStavki { get; set; }

        public string TableName => "Racun";

        public string Values { get; set; }= "";

        public string Join => "";

        public string Set { get; set; } ="";

        public string DefaultValues { get; set; }="";

        public string InsertCondition { get; set ; }
        public string UpdateCondition { get ; set ; }
        public string DeleteCondition { get ; set ; }
        public string SelectCondition { get ; set; }
        public string SelectValues { get; set; } = "*";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> res = new List<IEntity>();

            while (reader.Read())
            {

                Racun racun = new Racun
                {
                    IdRacun = (int)reader["idRacun"],
                    AdresaIzdavanja = (string)reader["adresaIzdavanja"],
                    datum = (DateTime)reader["datum"],
                    Iznos = (double)reader["iznos"],
                    Kupac = new Kupac
                    {
                        IdKupac= (int)reader["idKupca"]
                    },
                    Prodavac=new Prodavac
                    {
                        IdProdavac = (int)reader["idProdavca"]
                    }

                };

                res.Add(racun);

            }

            return res;
        }
    }
}
