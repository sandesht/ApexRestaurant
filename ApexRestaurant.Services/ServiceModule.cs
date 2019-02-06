using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;

namespace ApexRestaurant.Services
{
    public class ServiceModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IStaffService, StaffService>();
            services.AddTransient<IMenuService ,MenuService>();
            services.AddTransient<IMenuItemService,MenuItemService>();
        }
        
    }
}
