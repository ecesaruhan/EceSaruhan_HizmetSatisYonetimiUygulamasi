using System.Runtime.InteropServices.JavaScript;

namespace SalesUp.Entity;

public class Sale
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public DateTime SaleDate { get; set; } = DateTime.Now;
    public decimal Amount { get; set; }
    public List<SaleDetail> SaleDetails { get; set; }
}