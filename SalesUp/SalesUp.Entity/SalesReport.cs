namespace SalesUp.Entity;

public class SalesReport
{
    public int Id { get; set; }
    public DateTime ReportDate { get; set; }=DateTime.Now;
    public string ToId { get; set; }
    public string ToManager { get; set; }
    public string FromId { get; set; }
    public string FromStaff { get; set; }
    public int TotalSales { get; set; }
    public decimal TotalRevenue { get; set; }
}