using SalesUp.Entity;
using SalesUp.Shared.ViewModels;

namespace SalesUp.Business.Abstract;

public interface IOrderService
{
    Task CreateAsync(Order order);
    Task<List<AdminOrderViewModel>> GetOrdersAsync();
    Task<List<AdminOrderViewModel>> GetOrdersAsync(string userId);
    Task<List<AdminOrderViewModel>> GetOrdersAsync(int productId);
    Task<AdminOrderViewModel> GetOrderAsync(int orderId);
    Task CancelOrder(int orderId);
}