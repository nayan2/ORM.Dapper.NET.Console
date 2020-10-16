using System.Threading.Tasks;

namespace ORM.Dapper.Core
{
    public class App
    {
        private readonly Helper _helper;
        
        public App(Helper helper)
        {
            this._helper = helper;
        }

        public async Task Run(string[] args)
        {
            
        }
    }
}