using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using Dapper;
using ORM.Dapper.Service.Factory;

namespace ORM.Dapper.Service
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        private readonly IDapperDbConnectionFactory _dbConnectionFactory;
        
        public GenericRepository(IDapperDbConnectionFactory dbConnectionFactory)
        {
            this._dbConnectionFactory = dbConnectionFactory;
        }
        
        public DbConnection GetDbconnection()
        {
            throw new System.NotImplementedException();
        }

        public T Get(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            return this._dbConnectionFactory.Connection.Query<T>(sp, param, commandType: commandType).FirstOrDefault();
        }

        public List<T> GetAll(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }

        public int Execute(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }

        public T Insert(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }

        public T Update(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }
    }
}