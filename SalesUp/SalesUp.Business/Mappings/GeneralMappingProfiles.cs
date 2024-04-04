using AutoMapper;
using SalesUp.Entity;
using SalesUp.Entity.Identity;
using SalesUp.Shared.ViewModels;
using SalesUp.Shared.ViewModels.Customer;
using SalesUp.Shared.ViewModels.IdentityModels;
using SalesUp.Shared.ViewModels.Product;
using SalesUp.Shared.ViewModels.Sale;
using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.Business.Mappings;

public class GeneralMappingProfiles : Profile
{
    public GeneralMappingProfiles()
    {
        CreateMap<Customer, AddCustomerViewModel>().ReverseMap();
        CreateMap<Customer, CustomerViewModel>().ReverseMap();
        CreateMap<Customer, DeleteCustomerViewModel>().ReverseMap();
        CreateMap<Customer, EditCustomerViewModel>().ReverseMap();

        CreateMap<Product, ProductViewModel>().ReverseMap();
        CreateMap<Product, AddProductViewModel>().ReverseMap();
        CreateMap<Product, EditProductViewModel>().ReverseMap();
        CreateMap<Product, DeleteProductViewModel>().ReverseMap();

        CreateMap<Sale, SaleViewModel>().ReverseMap();
        CreateMap<Sale, AddSaleViewModel>().ReverseMap();
        CreateMap<Sale, DeleteSaleViewModel>().ReverseMap();
        CreateMap<Sale, EditSaleViewModel>().ReverseMap();
        CreateMap<SaleDetail, SaleDetailViewModel>().ReverseMap();

        CreateMap<STask, STaskViewModel>().ReverseMap();
        CreateMap<STask, DeleteSTaskViewModel>().ReverseMap();
        CreateMap<STask, AddSTaskViewModel>().ReverseMap();
        CreateMap<STask, EditSTaskViewModel>().ReverseMap();

        CreateMap<Order, OrderViewModel>().ReverseMap();
        CreateMap<Order, AdminOrderViewModel>().ReverseMap();

        CreateMap<Message, MessageViewModel>().ReverseMap();

        CreateMap<Subscription, SubscriptionViewModel>().ReverseMap();

        CreateMap<User, UserViewModel>().ReverseMap();
        CreateMap<User, UserProfileViewModel>().ReverseMap();
        CreateMap<User, UserRolesViewModel>().ReverseMap();
    }
}