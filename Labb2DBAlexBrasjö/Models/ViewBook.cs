using System;
using System.Collections.Generic;

namespace Labb2DBAlexBrasjö.Models;

public partial class ViewBook
{
    public string Isbn { get; set; } = null!;

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public decimal? Price { get; set; }

    public int? Stock { get; set; }

    public int StoreId { get; set; }

    public string? ImagePath { get; set; }
}
