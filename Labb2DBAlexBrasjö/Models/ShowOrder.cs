using System;
using System.Collections.Generic;

namespace Labb2DBAlexBrasjö.Models;

public partial class ShowOrder
{
    public int OrderId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Isbn { get; set; }

    public string? Title { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? StoreName { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }
}
