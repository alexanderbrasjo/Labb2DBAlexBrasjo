using System;
using System.Collections.Generic;

namespace Labb2DBAlexBrasjö.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public int? StoreId { get; set; }

    public virtual Store? Store { get; set; }
}
