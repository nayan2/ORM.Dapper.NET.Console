using System.Data;
using System.Threading.Tasks;
using Dapper;
using ORM.Dapper.Service;

namespace ORM.Dapper.Core
{
    public class App
    {
        private IGenericRepository<Mapper> _repository;
        
        public App(IGenericRepository<Mapper> repository)
        {
            this._repository = repository;
        }

        public async Task Run(string[] args)
        {
            var result = await this._repository.GetAll("SELECT * FROM dbo.Mappers", new DynamicParameters(), CommandType.Text);
        }
    }
}