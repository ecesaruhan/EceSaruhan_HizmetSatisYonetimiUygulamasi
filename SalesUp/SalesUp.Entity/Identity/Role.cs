using Microsoft.AspNetCore.Identity;

namespace SalesUp.Entity.Identity;

public class Role:IdentityRole
{
    public Employee Employee { get; set; }
}