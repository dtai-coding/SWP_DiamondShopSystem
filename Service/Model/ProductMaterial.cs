using System;
using System.Collections.Generic;

namespace Repository.Entities;

public class ProductMaterial
{
    public int ProductId { get; set; }

    public int? MaterialId { get; set; }

    public decimal Weight { get; set; }

}
