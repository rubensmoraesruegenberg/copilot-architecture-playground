using System.Threading.Tasks;
using SalesApi.Domain;

namespace SalesApi.Application.Interfaces;

public interface IProductRepository
{
    Task SaveAsync(Product product);
}
