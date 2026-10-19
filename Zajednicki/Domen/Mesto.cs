using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Mesto : IEntity
    {
        public int IdMesto { get; set; }
        public string Naziv {  get; set; }
        public string Drzava { get; set; }

        public string TableName => "Mesto";

        public string Values => "";

        public string Join => "";

        public string Set => "";

        public string DefaultValues => "";

        public string InsertCondition { get; set; }
        public string UpdateCondition { get; set ; }
        public string DeleteCondition { get; set ; }
        public string SelectCondition { get; set ; }
        public string SelectValues { get; set; } = "*";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> res = new List<IEntity>();

            while (reader.Read())
            {
                Mesto mesto= new Mesto
                {
                    IdMesto = (int)reader["idMesto"],
                    Naziv = (string)reader["naziv"],
                    Drzava = (string)reader["drzava"]
                    

                };
                
                res.Add(mesto);

            }

            return res;
        }

        public override string? ToString()
        {
            return $"{Naziv}, {Drzava}";
        }
    }
}
