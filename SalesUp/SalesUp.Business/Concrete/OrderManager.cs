using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;
using SalesUp.Entity;
using SalesUp.Shared.ViewModels;

namespace SalesUp.Business.Concrete;

public class OrderManager : IOrderService
{
    private readonly IMapper _mapper;
    private readonly IOrderRepository _repository;


    public OrderManager(IMapper mapper, IOrderRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task CreateAsync(Order order)
    {
        await _repository.CreateAsync(order);
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