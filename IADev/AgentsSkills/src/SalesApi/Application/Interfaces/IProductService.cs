using System.Threading.Tasks;
using SalesApi.Application.Commands;
using SalesApi.Presentation.Responses;

namespace SalesApi.Application.Interfaces;

public interface IProductService
{
    Task<ProductResponse> CreateAsync(CreateProductCommand command);
}
