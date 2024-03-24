using SalesUp.Entity.Identity;

namespace SalesUp.Entity;

public class Product
{
    public int Id { get; set; } 
    public string Name { get; set; } 
    public string Properties { get; set; } 
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public string Url { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
}
