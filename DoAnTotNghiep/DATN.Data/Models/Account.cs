using System;
using System.Collections.Generic;

namespace DATN.Data.Models;

public partial class Account
{
    public long Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public long UserId { get; set; }

    public int AccountStatus { get; set; }

    public int AccountRole { get; set; }

    public virtual ICollection<Bill> Bills { get; } = new List<Bill>();

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual User User { get; set; } = null!;
}
