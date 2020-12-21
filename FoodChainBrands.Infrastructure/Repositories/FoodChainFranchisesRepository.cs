using FoodChainBrands.Core;
using Microsoft.Extensions.Configuration;
using System;

namespace FoodChainBrands.Infrastructure
{
    public class FoodChainFranchisesRepository : GenericRepository<FoodChainFranchises>, IFoodChainFranchisesRepository
    {
        private readonly IDatabaseConnectionFactory _databaseConnectionFactory;
        public readonly IConfiguration _configuration;
        public FoodChainFranchisesRepository(IDatabaseConnectionFactory databaseConnectionFactory, IConfiguration configuration
            )
       : base(databaseConnectionFactory)
        {
            _databaseConnectionFactory = databaseConnectionFactory ?? throw new ArgumentNullException(nameof(databaseConnectionFactory));
            _configuration = configuration;
        }

    }
}
