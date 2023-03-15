using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class Producer
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Addess { get; set; }

    public string? Phone { get; set; }

    public int ProducerStatus { get; set; }

    public virtual ICollection<Asset> Assets { get; } = new List<Asset>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
