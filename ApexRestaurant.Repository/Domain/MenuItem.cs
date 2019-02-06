namespace ApexRestaurant.Repository.Domain
{
    public class MenuItem
    {
        public int menu_item_id { get; set; }
        public string menu_item_name { get; set; }

        public string other_detail { get; set; }

        public int menu_id{get;set;}
    }
}