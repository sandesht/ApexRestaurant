using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RCustomer;

namespace ApexRestaurant.Services.SCustomer
{
    public class MenuItemService:GenericService<MenuItem>, IMenuItemService 
    {
        public MenuItemService(IMenuItemRepository menuItemRepository): base(menuItemRepository)
        {
            
        }
    }
}