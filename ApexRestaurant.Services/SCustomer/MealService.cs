using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RCustomer;

namespace ApexRestaurant.Services.SCustomer
{
    public class MealService:GenericService<Meal>, IMealService
    {
        public MealService(IMealRepository mealRepostiory): base(mealRepostiory)
        {
            
        }
    }
}