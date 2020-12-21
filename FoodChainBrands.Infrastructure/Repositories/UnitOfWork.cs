using System;
using System.Collections.Generic;
using System.Text;

namespace FoodChainBrands.Infrastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        public UnitOfWork(IFoodChainRepository foodChainRepository,IFoodChainFranchisesRepository foodChainFranchiseRepository)
        {
            FoodChain = foodChainRepository;
            FoodChainFranchises = foodChainFranchiseRepository;
        }
        public IFoodChainRepository FoodChain { get; }
        public IFoodChainFranchisesRepository FoodChainFranchises { get; }

    }
}
