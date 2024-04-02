using Riok.Mapperly.Abstractions;
using SalesUp.Entity;
using SalesUp.Shared.ViewModels;
using SalesUp.Shared.ViewModels.Customer;
using SalesUp.Shared.ViewModels.Product;
using SalesUp.Shared.ViewModels.Sale;
using SalesUp.Shared.ViewModels.STask;


namespace SalesUp.Business.Mappings;

[Mapper]
public partial class MapperlyConfig
{
    #region Customer

    public partial CustomerViewModel CustomerToCustomerViewModel(Customer customer);
    public partial AddCustomerViewModel CustomerToAddCustomerViewModel(Customer customer);
    public partial EditCustomerViewModel CustomerToEditCustomerViewModel(Customer customer);
    public partial DeleteCustomerViewModel CustomerToDeleteCustomerViewModel(Customer customer);
    public partial Customer CustomerViewModelToCustomer(CustomerViewModel customerViewModel);
    public partial Customer AddCustomerViewModelToCustomer(AddCustomerViewModel addCustomerViewModel);
    public partial Customer EditCustomerViewModelToCustomer(EditCustomerViewModel editCustomerViewModel);
    public partial Customer DeleteCustomerViewModelToCustomer(DeleteCustomerViewModel deleteCustomerViewModel);

    #endregion

    #region Product

    public partial ProductViewModel ProductToProductViewModel(Product product);
    public partial AddProductViewModel ProductToAddProductViewModel(Product product);
    public partial EditProductViewModel ProductToEditProductViewModel(Product product);
    public partial DeleteProductViewModel ProductToDeleteProductViewModel(Product product);
    public partial Product ProductViewModelToProduct(ProductViewModel productViewModel);
    public partial Product AddProductViewModelToProduct(AddProductViewModel addProductViewModel);
    public partial Product EditProductViewModelToProduct(EditProductViewModel editProductViewModel);
    public partial Product DeleteProductViewModelToProduct(DeleteProductViewModel deleteProductViewModel);

    #endregion

    #region Sale

    public partial SaleViewModel SaleToSaleViewModel(Sale sale);
    public partial AddSaleViewModel SaleToAddSaleViewModel(Sale sale);
    public partial EditSaleViewModel SaleToEditSaleViewModel(Sale sale);
    public partial DeleteSaleViewModel SaleToDeleteSaleViewModel(Sale sale);
    public partial Sale SaleViewModelToSale(SaleViewModel saleViewModel);
    public partial Sale AddSaleViewModelToSale(AddSaleViewModel addSaleViewModel);
    public partial Sale EditSaleViewModelToSale(EditSaleViewModel editSaleViewModel);
    public partial Sale DeleteSaleViewModelToSale(DeleteSaleViewModel deleteSaleViewModel);
    public partial SaleDetailViewModel SaleDetailToSaleDetailViewModel(SaleDetail saleDetail);
    public partial SaleDetail SaleDetailViewModelToSaleDetail(SaleDetailViewModel saleDetailViewModel);

    #endregion

    #region STask

    public partial STaskViewModel STaskToSTaskViewModel(STask sTask);
    public partial AddSTaskItemViewModel STaskItemToAddSTaskItemViewModel(STaskItem sTaskItem);
    public partial EditSTaskItemViewModel STaskItemToEditSTaskItemViewModel(STaskItem sTaskItem);
    public partial DeleteSTaskItemViewModel STaskItemToDeleteSTaskItemViewModel(STaskItem sTaskItem);
    public partial STaskItemViewModel STaskItemToSTaskItemViewModel(STaskItem sTaskItem);
    public partial List<STaskItemViewModel> STaskItemListToSTaskItemListViewModel(List<STaskItem> sTaskItems);

    public partial STask STaskViewModelToSTask(STaskViewModel sTaskViewModel);
    
    public partial STaskItem AddSTaskItemViewModelToSTaskItem(AddSTaskItemViewModel addSTaskItemViewModel);
    public partial STaskItem EditSTaskItemViewModelToSTaskItem(EditSTaskItemViewModel editSTaskItemViewModel);
    public partial STaskItem DeleteSTaskItemViewModelToSTaskItem(DeleteSTaskItemViewModel deleteSTaskItemViewModel);
    public partial STaskItem STaskItemViewModelToSTaskItem(STaskItemViewModel sTaskItemViewModel);
    public partial List<STaskItem> STaskItemListViewModelToSTaskItemList(List<STaskItemViewModel> sTaskItemsViewModel);
    #endregion

    public partial OrderViewModel OrderToOrderViewModel(Order order);
    public partial Order OrderViewModelToOrder(OrderViewModel orderViewModel);
    public partial AdminOrderViewModel OrderToAdminOrderViewModel(Order order);
    public partial Order AdminOrderViewModelToOrder(AdminOrderViewModel adminOrderViewModel);
    public partial MessageViewModel MessageToMessageViewModel(Message message);
    public partial Message MessageViewModelToMessage(MessageViewModel messageViewModel);

    public partial SubscriptionViewModel SubscriptionToSubscriptionViewModel(Subscription subscription);
    public partial Subscription SubscriptionViewModelToSubscription(SubscriptionViewModel subscriptionViewModel);
    
}