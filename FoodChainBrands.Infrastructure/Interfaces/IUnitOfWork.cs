using System;
using System.Collections.Generic;
using System.Text;

namespace FoodChainBrands.Infrastructure
{
    public interface IUnitOfWork
    {
        IFoodChainRepository FoodChain { get; }
        IFoodChainFranchisesRepository FoodChainFranchises { get; }
    }
}
