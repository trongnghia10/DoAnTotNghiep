using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class Category
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public int CategoryStatus { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
