using System;
using System.Collections.Generic;

namespace Repository.Entities;

public class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public string? NiSize { get; set; }
}
