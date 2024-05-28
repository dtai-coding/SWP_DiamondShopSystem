﻿using System;
using System.Collections.Generic;

namespace Repository.Entities;

public class Discount
{
    public int DiscountId { get; set; }

    public int? OrderId { get; set; }

    public string DiscountCode { get; set; } = null!;

    public decimal DiscountAmount { get; set; }

    public DateOnly DiscountDate { get; set; }

    public bool DiscountStatus { get; set; }
}
