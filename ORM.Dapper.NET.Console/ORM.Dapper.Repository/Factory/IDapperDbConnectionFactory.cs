using System.Data;

namespace ORM.Dapper.Service.Factory
{
    public interface IDapperDbConnectionFactory
    {
        IDbConnection Connection { get; }
    }
}