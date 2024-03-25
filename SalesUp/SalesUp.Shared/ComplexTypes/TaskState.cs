using System.ComponentModel.DataAnnotations;

namespace SalesUp.Shared.ComplexTypes;

public enum TaskState
{
    [Display(Name = "Planlandı")]
    Todo=0,
    
    [Display(Name = "Görüşme Aşamasında")]
    Processing=0,
    
    [Display(Name = "Tamamlandı")]
    Completed=1
}