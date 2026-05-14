using System.Threading.Tasks;
using SalesApi.Application.Interfaces;
using SalesApi.Domain;

namespace SalesApi.Infrastructure;

public class ProductRepository : IProductRepository
{
    public Task SaveAsync(Product product)
    {
        // Persistência deve ser tratada na camada de Infrastructure.
        return Task.CompletedTask;
    }
}
