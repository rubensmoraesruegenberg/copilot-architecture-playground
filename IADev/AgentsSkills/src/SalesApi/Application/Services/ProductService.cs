using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SalesApi.Application.Commands;
using SalesApi.Application.Interfaces;
using SalesApi.Domain;
using SalesApi.Presentation.Responses;

namespace SalesApi.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    private readonly ILogger<ProductService> _logger;

    public ProductService(IProductRepository repository, ILogger<ProductService> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<ProductResponse> CreateAsync(CreateProductCommand command)
    {
        var product = new Product(command.Price);

        if (product.IsHighValue())
        {
            _logger.LogInformation("Preço alto");
        }

        await _repository.SaveAsync(product);

        return new ProductResponse
        {
            Price = product.Price
        };
    }
}
