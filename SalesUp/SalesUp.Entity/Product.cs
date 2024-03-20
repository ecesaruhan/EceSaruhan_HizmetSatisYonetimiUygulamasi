using SalesUp.Entity.Identity;

namespace SalesUp.Entity;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public string Url { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    
}