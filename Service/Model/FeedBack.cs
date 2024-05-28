using System;
using System.Collections.Generic;

namespace Repository.Entities;

public  class FeedBack
{
    public int FeedbackId { get; set; }

    public int? OrderDetailId { get; set; }

    public int? UserId { get; set; }

    public string? FeedbackText { get; set; }

    public DateTime Date { get; set; }

}
