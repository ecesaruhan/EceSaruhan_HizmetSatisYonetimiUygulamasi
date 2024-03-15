namespace SalesUp.Entity;

public class Region
{
    public int Id { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public Employee Employee { get; set; }
    public Manager Manager { get; set; }
}