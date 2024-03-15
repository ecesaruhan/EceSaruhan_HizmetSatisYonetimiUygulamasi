namespace SalesUp.Entity;

public class Manager
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string JobTitle { get; set; }
    
    public int RegionId { get; set; }
    public List<Region> Regions { get; set; }

    public List<Employee> Employees { get; set; }
    
}