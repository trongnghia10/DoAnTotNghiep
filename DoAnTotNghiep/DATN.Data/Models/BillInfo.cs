using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class BillInfo
{
    public long Id { get; set; }

    public long BillId { get; set; }

    public long ProductId { get; set; }

    public long Price { get; set; }

    public long QuantityPurchased { get; set; }

    public virtual Bill Bill { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
