using Microsoft.AspNetCore.Mvc;
using SalesApi.Application.Commands;
using SalesApi.Application.Interfaces;
using SalesApi.Presentation.Requests;
using SalesApi.Presentation.Responses;

namespace SalesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductRequest request)
    {
        var command = new CreateProductCommand
        {
            Price = request.Price
        };

        var response = await _productService.CreateAsync(command);
        return Ok(response);
    }
}
