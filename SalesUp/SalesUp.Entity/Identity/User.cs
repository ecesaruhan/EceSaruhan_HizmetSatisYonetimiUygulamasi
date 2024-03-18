using Microsoft.AspNetCore.Identity;

namespace SalesUp.Entity.Identity;

public class User:IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Gender { get; set; }
    public DateTime? DateofBirth { get; set; }
    public string Company { get; set; }
    public Product Product { get; set; }
    public Role Role { get; set; }
    public Customer Customer { get; set; }
    
}