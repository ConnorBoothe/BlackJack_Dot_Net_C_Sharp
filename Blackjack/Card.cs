using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Card
    {
        public String suit { get; set; }
        public String rank { get; set; }
        public Card(String suit, String rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
        public String getCard()
        {
            return this.rank + " of "+ this.suit;
        }

        public int getValue()
        {
            int value = 0;
            switch (this.rank)
            {
                case "Ace":
                    Console.WriteLine("You drew an ace. Would you like 1 or 11?");
                    int aceSelection = Int16.Parse(Console.ReadLine());
                    value = aceSelection;
                    break;
                case "Jack":
                    value = 10;
                    break;
                case "Queen":
                    value = 10;
                    break;
                case "King":
                    value = 10;
                    break;
                default:
                    value = Int16.Parse(this.rank);
                    break;
            }
            return value;
        }


    }
}
