using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Eat()
        {
            // Will select a random restaurant name from a list of strings (List of restaurant names can come from anywhere),
            // print to console that the buddy is at that restaurant, and also return the restaurant.
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.RestaurantList}.");
            Console.ReadLine();

        }

        public void EatString(string food)
        {
            // Will output that the buddy ate that specific food at the office.
            Console.WriteLine($"Buddy ate {food} at the office.");
            Console.ReadLine();

        }

        public void EatList(List<LunchBuddy> companions)
        {
            //Will select a random restaurant name from a list of strings, print to console that the buddy is at that restaurant,
            //and also output the first name of each lunch buddy in the specified list.
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.RestaurantList} with ");
            foreach (var companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }

            Console.ReadLine();

        }

        public void EatStringAndList(string food, List<LunchBuddy> companions)
        {
            // Will select a random restaurant name from a list of strings, print to console that the buddy at that restaurant,
            // and ordered the specified food, with the first name of the teammates specified in the list.
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.RestaurantList} and ordered {food} while eating with ");
            foreach (var companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }
            Console.ReadLine();

        }


    }
}
