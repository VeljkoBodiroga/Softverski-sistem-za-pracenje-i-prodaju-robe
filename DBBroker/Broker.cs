using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Security.Principal;
using Zajednicki.Domen;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }
        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName}";
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list;
        }

        public void Add(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {entity.TableName} values({entity.Values})";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public int Create(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} values ({obj.DefaultValues}) SELECT SCOPE_IDENTITY()";
            Debug.WriteLine(command.CommandText);
            object id = command.ExecuteScalar();
            command.Dispose();
            Debug.WriteLine(">>>>>>" + Convert.ToInt32(id));
            return Convert.ToInt32(id);
        }

        public List<IEntity> GetByCondition(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT  {entity.SelectValues} FROM {entity.TableName} {entity.Join} WHERE {entity.SelectCondition}";
            Debug.WriteLine(command.CommandText);
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list;
        }

        public void DeleteEntity(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.SelectCondition}";
            Debug.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void UpdateByCondition(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"UPDATE {entity.TableName} {entity.Set} WHERE {entity.SelectCondition}";
            Debug.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        
    }
}
