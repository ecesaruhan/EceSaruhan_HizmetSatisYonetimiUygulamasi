using SalesUp.Entity.Identity;

namespace SalesUp.Entity;

public class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }=DateTime.Now;
    public string UserId { get; set; }
    public User User { get; set; }
    public string CustomerId { get; set; }
    public Customer Customer { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}