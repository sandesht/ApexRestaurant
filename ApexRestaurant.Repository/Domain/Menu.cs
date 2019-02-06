using System;

namespace ApexRestaurant.Repository.Domain
{
    public class Menu
    {
        public int menu_id { get; set; }
        public string menu_name { get; set; }
        public DateTime available_date_form { get; set; }
        public DateTime available_date_to { get; set; }
        public string other_details { get; set; }
    }

}