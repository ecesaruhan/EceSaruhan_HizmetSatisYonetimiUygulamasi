using System.ComponentModel.DataAnnotations;

namespace SalesUp.Shared.ComplexTypes;

public enum SubscriptionType
{
    [Display(Name = "Haftalık")]
    Weekly=0,
    
    [Display(Name = "Aylık")]
    Monthly=1,
    
    [Display(Name = "Yıllık")]
    Annual=2
}