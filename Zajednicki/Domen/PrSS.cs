using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class PrSS:IEntity
    {
        public int IdProdavac {  get; set; }
        public int IdStrucnaSprema { get; set; }
        public DateTime DatumIzdavanja { get; set; }

        public string TableName => "PrSS";

        public string Values { get; set; }="";

        public string Join => "";

        public string Set =>"";

        public string DefaultValues => "";

        public string InsertCondition { get ; set; }
        public string UpdateCondition { get ; set; }
        public string DeleteCondition { get; set; }
        public string SelectCondition { get; set; }
        public string SelectValues { get; set; } = "*";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> res = new List<IEntity>();

            while (reader.Read())
            {

                PrSS prSS = new PrSS
                {
                    IdProdavac = (int)reader["idProdavac"],
                    IdStrucnaSprema = (int)reader["idStrucnaSprema"],
                    DatumIzdavanja = (DateTime)reader["datumIzdavanja"],
                    

                };

                res.Add(prSS);

            }

            return res;
        }
    }
}
