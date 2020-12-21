
namespace FoodChainBrands.Infrastructure
{
    public interface IIdentityInspector<TEntity> where TEntity : class
    {
        string GetColumnsIdentityForType();
    }
}
