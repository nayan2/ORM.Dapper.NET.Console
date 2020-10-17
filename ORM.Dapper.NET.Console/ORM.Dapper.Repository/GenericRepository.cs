using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ORM.Dapper.Service.Factory;

namespace ORM.Dapper.Service
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        protected readonly IDapperDbConnectionFactory DbConnectionFactory;
        
        public GenericRepository(IDapperDbConnectionFactory dbConnectionFactory)
        {
            this.DbConnectionFactory = dbConnectionFactory;
        }

        public async Task<T> Get(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            var result = await this.DbConnectionFactory.Connection.QueryAsync<T>(sp, param, commandType: commandType);
            return result.FirstOrDefault();
        }

        public async Task<List<T>> GetAll(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            var result = await this.DbConnectionFactory.Connection.QueryAsync<T>(sp, param, commandType: commandType);
            return result.ToList();
        }

        public Task<int> Execute(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Insert(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Update(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new System.NotImplementedException();
        }
    }
}