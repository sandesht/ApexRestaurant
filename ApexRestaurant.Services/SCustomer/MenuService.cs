using ApexRestaurant.Repository;
using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RCustomer;

namespace ApexRestaurant.Services.SCustomer
{
    public class MenuService : GenericService<Menu>, IMenuService
    {
      public MenuService(IMenuRepository menuRepository):base(menuRepository)
      {
          
      }
    }
}