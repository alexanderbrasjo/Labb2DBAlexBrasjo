using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb2DBAlexBrasjö.Models;

public partial class Author
{
    public int AuthorId { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public DateTime? BirthDate { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
