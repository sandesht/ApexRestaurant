using System;

namespace ApexRestaurant.Repository.Domain
{
    public class Meal
    {
        public int meal_id { get; set; }
        public DateTime date_of_meal { get; set; }
        public int cost_of_meal { get; set; }
        public string other_details{get;set;}

        public int customer_id { get; set; }
        public int staff_id { get; set; }
    }
}