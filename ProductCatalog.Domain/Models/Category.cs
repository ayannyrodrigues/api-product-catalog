using System.Collections.ObjectModel;

namespace ProductCatalog.Domain.Models;

public class Category
{
    public Category() 
    { 
        Products = new Collection<Product>();
    }

    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public string? UrlImage { get; set; }
    public ICollection<Product>? Products { get; set; }
}
