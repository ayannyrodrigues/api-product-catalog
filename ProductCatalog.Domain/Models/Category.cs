using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Domain.Models;

public class Category
{
    public Category() 
    { 
        Products = new Collection<Product>();
    }

    public int CategoryId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Name { get; set; }

    [Required]
    [StringLength(300)]
    public string? UrlImage { get; set; }

    public ICollection<Product>? Products { get; set; }
}
