﻿using System;
using System.Collections.Generic;

namespace ShoeShop.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
