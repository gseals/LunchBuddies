using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LunchBuddy> buddies = new List<LunchBuddy>();
            var LunchBuddy = new LunchBuddy("Mr.", "Twister");
            var buddy = new LunchBuddy("Mikey", "Jones");

            buddies.Add(new LunchBuddy("Ryan", "Cargo"));
            buddies.Add(new LunchBuddy("Matthew", "Slowdown"));
            buddies.Add(new LunchBuddy("Brandon", "Mediumspeed"));
            buddy.Eat();
            buddy.EatString("spaghetti");
            buddy.EatList(buddies);
            buddy.EatStringAndList("monkeys", buddies);

        }
    }
}
