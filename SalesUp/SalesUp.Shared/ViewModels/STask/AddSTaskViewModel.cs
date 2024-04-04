using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SalesUp.Shared.ComplexTypes;
using SalesUp.Shared.ViewModels.Customer;
using SalesUp.Shared.ViewModels.Product;

namespace SalesUp.Shared.ViewModels.STask;

public class AddSTaskViewModel
{
    [JsonPropertyName("Title")]
    [DisplayName("�r�n")]
    [Required(ErrorMessage = "{0} alan� bo� b�rak�lamaz.")]
    [MinLength(5, ErrorMessage = "{0} alan�na uzunlu�u {1} karakterden k���k de�er girilemez.")]
    [MaxLength(100, ErrorMessage = "{0} alan�na uzunlu�u {1} karakterden b�y�k de�er girilemez.")]
    public string Title { get; set; }
    
    
    [JsonPropertyName("CreatedDate")]
    [DisplayName("Oluşturulma Tarihi")]
    public DateTime CreatedDate { get; set; }
    
    [JsonPropertyName("ModifiedDate")]
    [DisplayName("Düzenlenme Tarihi")]
    public DateTime ModifiedDate { get; set; }
    
    [JsonPropertyName("Customer")]
    [DisplayName("Müşteri Bilgileri")]
    public CustomerViewModel Customer { get; set; }
    
    [JsonPropertyName("Product")]
    [DisplayName("Ürün Bilgileri")]
    public ProductViewModel Product { get; set; }
    
    [JsonPropertyName("IsCompleted")]
    [DisplayName("Tamamlanmış Görev")]
    public bool IsCompleted { get; set; }
    
    [JsonPropertyName("Note")]
    [DisplayName("Görev Notları")]
    public string Note { get; set; }
}