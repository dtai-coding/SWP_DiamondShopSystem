using System;
using System.Collections.Generic;

namespace Repository.Entities;

public class ProductCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? CategoryType { get; set; }

    public bool CategoryStatus { get; set; }

}
