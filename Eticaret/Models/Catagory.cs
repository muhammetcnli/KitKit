namespace Eticaret.Models
{
    public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Product>? Products { get; set; }
}
}