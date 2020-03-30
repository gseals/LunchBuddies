using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        private List<string> _restaurantList = new List<string>{ "Papa Johns", "Pizza Hut", "Pizza Perfect", "Domino's", "Little Caesers"};

        public string RestaurantList { get; set; }
        public Restaurant()
        {
            Random random = new Random();

            var randomRestaurant = random.Next(4);
            RestaurantList = _restaurantList[randomRestaurant];
        }

    }

}
