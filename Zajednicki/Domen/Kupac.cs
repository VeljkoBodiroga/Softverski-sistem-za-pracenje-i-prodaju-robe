using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Kupac:IEntity
    {
        public int IdKupac {  get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrTelefona { get; set; }

        public Mesto Mesto { get; set; }

        public string TableName => "Kupac";



        public string Values { get; set; } = "";

        public string Join => "";

        public string Set { get; set; } ="";

        public string DefaultValues => "";

        public string InsertCondition { get; set; }
        public string UpdateCondition { get ; set ; }
        public string DeleteCondition { get; set; }
        public string SelectCondition { get; set; }
        public string SelectValues { get; set ; } = "*";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> res = new List<IEntity>();

            while (reader.Read())
            {
                
                Kupac kupac = new Kupac
                {
                    IdKupac = (int)reader["idKupac"],
                    Ime = (string)reader["ime"],
                    Prezime = (string)reader["prezime"],
                    BrTelefona = (string)reader["brojTelefona"],
                    Mesto = new Mesto
                    {
                        IdMesto = (int)reader["idMesto"]
                    }

                };
                
                res.Add(kupac);

            }

            return res;
        }

        public override string? ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
