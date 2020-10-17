using System;
using Microsoft.Extensions.Configuration;

namespace ORM.Dapper.Service
{
    public class Helper
    {
        private readonly IConfiguration _configuration;
        
        public Helper(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        
        public string ConnectionString(string name)
        {
            return this._configuration.GetConnectionString(name);
        }
    }
}