using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class SportskaOprema:IEntity
    {
        public int IdSportskeOpreme { get; set; }
        public string VrstaModela {  get; set; }
        public string Marka {  get; set; }
        public double Cena { get; set; }
        public string Sport {  get; set; }

        public string TableName => "SportskaOprema";

        public string Values => "";

        public string Join => "";

        public string Set => "";

        public string DefaultValues => "";

        public override string? ToString()
        {
            return $"{Marka}, {VrstaModela}";
        }

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
                SportskaOprema so = new SportskaOprema
                {
                    IdSportskeOpreme = (int)reader["idSportskeOpreme"],
                    VrstaModela = (string)reader["vrstaModela"],
                    Marka = (string)reader["marka"],
                    Cena = (double)reader["cena"],
                    Sport = (string)reader["sport"]


                };

                res.Add(so);

            }

            return res;
        }
    }
}
