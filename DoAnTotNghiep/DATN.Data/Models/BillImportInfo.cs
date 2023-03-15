using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class BillImportInfo
{
    public long Id { get; set; }

    public long ProductId { get; set; }

    public long BillImportId { get; set; }

    public long Price { get; set; }

    public int NumberImport { get; set; }

    public virtual BillImport BillImport { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
