using Microsoft.AspNetCore.Identity;

namespace SalesUp.Entity.Identity;

public class User:IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Employee Employee { get; set; }
}