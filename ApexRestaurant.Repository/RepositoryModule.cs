using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;
namespace ApexRestaurant.Repository
{
    public class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection,
        string migrationsAssembly)
        {
             services.AddDbContext<RestaurantContext>(options =>
            options.UseSqlServer(connection, builder =>
            builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMealRepository, MealRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IMenuItemRepository,MenuItemRepository>();
            services.AddTransient<IStaffRepository,StaffRepository>();
            services.AddTransient<IMealRepository,MealRepository>();
        }
    }
}