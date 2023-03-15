using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class User
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public int UserSatus { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<BillImport> BillImports { get; } = new List<BillImport>();
}
