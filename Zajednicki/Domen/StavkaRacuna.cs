using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class StavkaRacuna : IEntity
    {   
        public int IdRacun {  get; set; }
        public int IdStavkaRacuna { get; set; }
        public string Naziv {  get; set; }
        public int Kolicina { get; set; }
        public double CenaStavke { get; set;}
        public int idSportskeOpreme {  get; set; }

        public bool zaBrisanje { get; set; } = false;
        public bool zaDodavanje {  get; set; }=false;

        public string TableName => "StavkaRacuna";

        public string Values { get; set; }= "";

        public string Join => "";

        public string Set => "";

        public string DefaultValues => "";

        public string InsertCondition { get; set ; }
        public string UpdateCondition { get; set; }
        public string DeleteCondition { get; set ; }
        public string SelectCondition { get; set; }
        public string SelectValues { get; set; } = "*";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> res = new List<IEntity>();

            while (reader.Read())
            {

                StavkaRacuna sr = new StavkaRacuna
                {
                    IdRacun = (int)reader["idRacun"],
                    IdStavkaRacuna = (int)reader["idStavkaRacuna"],
                    Naziv = (string)reader["naziv"],
                    Kolicina = (int)reader["kolicina"],
                    CenaStavke = (double)reader["cenaStavke"],
                    idSportskeOpreme = (int)reader["idSportskeOpreme"]

                };

                res.Add(sr);

            }

            return res;
        }

        public override string? ToString()
        {
            return $"{Naziv} {Kolicina} {CenaStavke}";
        }
    }
}
