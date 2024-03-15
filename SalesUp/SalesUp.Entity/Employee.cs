namespace SalesUp.Entity;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string JobTitle { get; set; }
    
    public int RegionId { get; set; }
    public Region Region { get; set; }
    
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    public int ManagerId { get; set; }
    public Manager Manager { get; set; }
    
    public int UserId { get; set; }

    public List<EmployeeCustomer> EmployeeCustomers { get; set; }
}