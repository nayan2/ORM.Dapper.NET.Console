using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using Dapper;

namespace ORM.Dapper.Service
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> Get(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);    
        Task<List<T>> GetAll(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);    
        Task<int> Execute(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);    
        Task<T> Insert(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);    
        Task<T> Update(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);  
    }
}