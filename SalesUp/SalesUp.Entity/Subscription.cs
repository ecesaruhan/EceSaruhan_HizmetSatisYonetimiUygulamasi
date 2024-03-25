namespace SalesUp.Entity;

public class Subscription
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Duration { get; set; }
    public string Type { get; set; } 
    // Aylık, Yıllık ve Ömür boyu seçenekleri

    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }=DateTime.Now;
    public DateTime UpdateDate { get; set; }=DateTime.Now;
}