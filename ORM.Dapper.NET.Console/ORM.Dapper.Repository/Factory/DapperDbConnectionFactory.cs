using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ORM.Dapper.Service.Factory
{
    public class DapperDbConnectionFactory: IDapperDbConnectionFactory
    {
        public DapperDbConnectionFactory(Helper helper)
        {
            this.Connection = new SqlConnection(helper.ConnectionString("DapperTest"));
        }
        
        public IDbConnection Connection { get; private set; }
    }
}