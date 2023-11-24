using System;
using System.Collections.Generic;

namespace Labb2DBAlexBrasjö.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public string? Isbn { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? StoreId { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Book? IsbnNavigation { get; set; }

    public virtual Store? Store { get; set; }
}
