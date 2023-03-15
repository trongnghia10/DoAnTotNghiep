using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class Product
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreationTime { get; set; }

    public long AmountProduct { get; set; }

    public long Price { get; set; }

    public long ProducerId { get; set; }

    public long CategoryId { get; set; }

    public int ProductStatus { get; set; }

    public string? Description { get; set; }

    public string? Color { get; set; }

    public long Size { get; set; }

    public string? ProCode { get; set; }

    public virtual ICollection<Asset> Assets { get; } = new List<Asset>();

    public virtual ICollection<BillImportInfo> BillImportInfos { get; } = new List<BillImportInfo>();

    public virtual ICollection<BillInfo> BillInfos { get; } = new List<BillInfo>();

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual Category Category { get; set; } = null!;

    public virtual Producer Producer { get; set; } = null!;
}
