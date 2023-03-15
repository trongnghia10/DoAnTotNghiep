using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class Bill
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long TotalPrice { get; set; }

    public int BillStatus { get; set; }

    public long AccountId { get; set; }

    public long Vat { get; set; }

    public string? Address { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<BillInfo> BillInfos { get; } = new List<BillInfo>();
}
