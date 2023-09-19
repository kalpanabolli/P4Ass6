using System;
using System.Collections.Generic;

namespace Ass6.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int? CategoryId { get; set; }

    public int? PublisherId { get; set; }

    public virtual BookCategory? Category { get; set; }

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
}
