namespace SalesUp.Entity;

public class Customer
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public int RegionId { get; set; }

    public List<EmployeeCustomer> EmployeeCustomers { get; set; }
}