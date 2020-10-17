using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Dapper;

namespace ORM.Dapper.Service
{
    public interface IGenericRepository<T> where T: class
    {
        DbConnection GetDbconnection();
        T Get(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);    
        List<T> GetAll(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);    
        int Execute(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);    
        T Insert(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);    
        T Update(string sp, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);  
    }
}