using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb2DBAlexBrasjö.Models;

public partial class Book
{
    [Required]
    public string Isbn { get; set; } = null!;
    [Required]
    public string? Title { get; set; }
    
    public int? CategoryId { get; set; }
    [Required]
    public string? Language { get; set; }
    [Required]
    public decimal? Price { get; set; }
    [Required]
    public DateTime? ReleaseDate { get; set; }
    
    public int? AuthorId { get; set; }
    
    public string? ImagePath { get; set; }

    public virtual Author? Author { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
