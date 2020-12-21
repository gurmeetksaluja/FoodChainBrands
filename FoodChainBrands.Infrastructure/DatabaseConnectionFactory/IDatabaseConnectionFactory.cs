using System.Data;
using System.Threading.Tasks;

namespace FoodChainBrands.Infrastructure
{
    public interface IDatabaseConnectionFactory
    {
        Task<IDbConnection> CreateConnectionAsync();
        IDbConnection CreateConnection();
    }
}
