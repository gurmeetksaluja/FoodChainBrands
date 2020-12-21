using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodChainBrands.Infrastructure
{
    public class FoodChainRepository : GenericRepository<FoodChainBrands.Core.FoodChainBrands>, IFoodChainRepository
    {
        private readonly IDatabaseConnectionFactory _databaseConnectionFactory;
        public readonly IConfiguration _configuration;
        public FoodChainRepository(IDatabaseConnectionFactory databaseConnectionFactory, IConfiguration configuration
            )
       : base(databaseConnectionFactory)
        {
            _databaseConnectionFactory = databaseConnectionFactory ?? throw new ArgumentNullException(nameof(databaseConnectionFactory));
            _configuration = configuration;
        }

        //public async Task<IEnumerable<FoodChainBrands>> GetAllFoodChains()
        //{
        //    return await AllAsync();
        //}

    }
}
