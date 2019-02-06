using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RCustomer;

namespace ApexRestaurant.Services.SCustomer
{
    public class StaffService: GenericService<Staff>, IStaffService 
    {
        public StaffService(IStaffRepository staffRepository) : base(staffRepository)
        {
            
        }
    }
}