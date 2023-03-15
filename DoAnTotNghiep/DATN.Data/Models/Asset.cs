using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class Asset
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public long? ProducerId { get; set; }

    public long? ProductId { get; set; }

    public virtual Producer? Producer { get; set; }

    public virtual Product? Product { get; set; }
}
