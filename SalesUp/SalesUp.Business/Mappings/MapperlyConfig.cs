using Riok.Mapperly.Abstractions;
using SalesUp.Entity;
using SalesUp.Shared.ViewModels.Customer;

namespace SalesUp.Business.Mappings;

[Mapper]
public partial class MapperlyConfig
{
    public partial CustomerViewModel CustomerToCustomerViewModel(Customer customer);
    public partial Customer CustomerViewModelToCustomer(CustomerViewModel customerViewModel);

}