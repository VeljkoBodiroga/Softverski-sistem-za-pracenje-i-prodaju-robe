using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Zajednicki.Domen
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string Join { get; }
        string Set { get; }
        string DefaultValues { get; }
        string InsertCondition { get; set; }
        string UpdateCondition { get; set; }
        string DeleteCondition { get; set; }
        string SelectCondition { get; set; }
        string SelectValues { get; set; }

        List<IEntity> GetReaderList(SqlDataReader reader);
    }
}
