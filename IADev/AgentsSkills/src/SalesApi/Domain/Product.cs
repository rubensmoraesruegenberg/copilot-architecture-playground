using System;

namespace SalesApi.Domain;

public class Product
{
    public int Id { get; set; }
    public decimal Price { get; }

    public Product(decimal price)
    {
        if (price < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "O preço deve ser maior ou igual a zero.");
        }

        Price = price;
    }

    public bool IsHighValue()
    {
        return Price > 100;
    }
}

