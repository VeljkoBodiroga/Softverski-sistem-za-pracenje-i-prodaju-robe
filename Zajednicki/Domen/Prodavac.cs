using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Prodavac : IEntity
    {
        public int IdProdavac {  get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string KorisnikoIme {  get; set; }
        public string Sifra {  get; set; }

        public string TableName => "Prodavac";

        public string Values { get; set; } ="";

        public string Join {  get; set; }

        public string Set => "";

        public string DefaultValues => "";

        public string InsertCondition { get; set; }
        public string UpdateCondition { get; set; }
        public string DeleteCondition { get; set; }
        public string SelectCondition { get; set; }
        public string SelectValues { get; set; } = "*";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> res = new List<IEntity>();

            while (reader.Read())
            {
                Prodavac prodavac = new Prodavac
                {
                    IdProdavac = (int)reader["idProdavac"],
                    Ime = (string)reader["ime"],
                    Prezime = (string)reader["prezime"],                
                    KorisnikoIme= (string)reader["korisnickoIme"],
                    Sifra = (string)reader["sifra"]

                };
                Debug.WriteLine(prodavac.ToString());
                res.Add(prodavac);

            }

            return res;
        }

        public override string? ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
