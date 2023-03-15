using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class BillImport
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long TotalPrice { get; set; }

    public long UserId { get; set; }

    public int BillImportType { get; set; }

    public virtual ICollection<BillImportInfo> BillImportInfos { get; } = new List<BillImportInfo>();

    public virtual User User { get; set; } = null!;
}
