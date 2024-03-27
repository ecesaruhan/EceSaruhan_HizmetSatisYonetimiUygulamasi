using SalesUp.Business.Abstract;
using SalesUp.Data.Abstract;
using SalesUp.Entity;
using SalesUp.Shared.ViewModels;

namespace SalesUp.Business.Concrete;

public class OrderManager : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderManager(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public async Task CreateAsync(Order order)
    {
        await _orderRepository.CreateAsync(order);
    }

    public Task<List<AdminOrderViewModel>> GetOrdersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<AdminOrderViewModel>> GetOrdersAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<List<AdminOrderViewModel>> GetOrdersAsync(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<AdminOrderViewModel> GetOrderAsync(int orderId)
    {
        throw new NotImplementedException();
    }

    public Task CancelOrder(int orderId)
    {
        throw new NotImplementedException();
    }
}