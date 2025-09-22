using System.Security.Cryptography.X509Certificates;

namespace CrudApi.Models
{
  public class Product
  {
    public int Id { get; set; } //pk
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
  }
}