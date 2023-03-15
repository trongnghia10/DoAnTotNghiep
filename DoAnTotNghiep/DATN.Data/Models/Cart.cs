using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class Cart
{
    public long Id { get; set; }

    public long ProductId { get; set; }

    public long AccountId { get; set; }

    public long Price { get; set; }

    public long QuantityPurchased { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
