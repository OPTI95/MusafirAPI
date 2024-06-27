using System;
using System.Collections.Generic;

namespace MusafirAPI.Models;

public partial class Product
{
    public Guid ProductId { get; set; }

    public string Sku { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal? MeasurementValue { get; set; }

    public string? MeasurementUnit { get; set; }

    public DateOnly ManufactureDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? Image { get; set; }

    public Guid? CategoryId { get; set; }

}
