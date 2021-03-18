using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Game
    {
        public int user_score = 0;
        public int dealer_score = 0;

        public String Play()
        {
            var deck = new Deck();
            deck.createDeck();
            Console.WriteLine("Shuffling the deck...");
            deck.shuffleDeck();
            int iterator = 0;
            while (user_score < 21 && dealer_score < 21)
            {
                if(iterator == 0)
                {
                    Card card = deck.drawCard();
                    Console.WriteLine("You drew a " + card.getCard());
                    user_score += card.getValue();
                    Console.WriteLine("Your Score: " + user_score);

                    Card dealer_card = deck.drawCard();
                    Console.WriteLine("The dealer drew a " + dealer_card.getCard());
                    dealer_score += dealer_card.getValue();
                    Console.WriteLine("Dealer Score: " + dealer_score);
                }
                else
                {
                    Console.WriteLine("Hit or Stand?");
                    String hitOrStand = Console.ReadLine().ToLower();

                    if (hitOrStand == "hit")
                    {
                        Card card = deck.drawCard();
                        Console.WriteLine("You drew a " + card.getCard());
                        user_score += card.getValue();
                        Console.WriteLine("Your Score: " + user_score);
                    }

                    Card dealer_card = deck.drawCard();
                    Console.WriteLine("The dealer drew a " + dealer_card.getCard());
                    dealer_score += dealer_card.getValue();
                    Console.WriteLine("Dealer Score: " + dealer_score);
                }
                iterator++;

            }
            return determineWinner();
            
        }
        public void resetGame()
        {
            user_score = 0;
            dealer_score = 0;
        }
        public String determineWinner()
        {

            Console.WriteLine("User Score: " + user_score);
            if (dealer_score > 21 && user_score < 21)
            {
                return "user";
            }
            else if(user_score >  21 && dealer_score < 21)
            {
                return "dealer";
            }
            else if (user_score == 21 && dealer_score != 21)
            {
                return "user";
            }
            else if (dealer_score == 21 && user_score != 21)
            {
                return "dealer";
            }
            else
            {
                return "Game busted";
            }

        }
    }
}
