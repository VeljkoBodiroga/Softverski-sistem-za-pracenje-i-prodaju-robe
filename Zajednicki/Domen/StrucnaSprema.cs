using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class StrucnaSprema :IEntity
    {
        public int IdStrucnaSprema {  get; set; }
        public string Naziv {  get; set; }
        public string Nivo { get; set; }

        public string TableName => "StrucnaSprema";

        public string Values { get; set; } = "";

        public string Join => "";

        public string Set => "";

        public string DefaultValues => "";

        public string InsertCondition { get; set; }
        public string UpdateCondition { get; set ; }
        public string DeleteCondition { get; set; }
        public string SelectCondition { get; set; }
        public string SelectValues { get; set; } = "*";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> res = new List<IEntity>();

            while (reader.Read())
            {
                StrucnaSprema ss = new StrucnaSprema
                {
                    IdStrucnaSprema = (int)reader["idStrucnaSprema"],
                    Naziv = (string)reader["naziv"],
                    Nivo = (string)reader["nivo"],
                    

                };
                
                res.Add(ss);

            }

            return res;
        }
    }
}
