using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
   
    public class Deck
    {
        public List<Card> deck { get; set; }
        Random random = new Random();
        public void createDeck()
        {
            deck = new List<Card>();
            //save all potential suits to an array
            string[] suits = new string[] { "Hearts", "Clubs", "Diamonds", "Spades" };
            string[] ranks = new string[] { "Ace", "2", "3","4","5","6","7","8","9","10",
                                            "Jack","Queen","King" };
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 13; j++)
                {
                    deck.Add(new Card(suits[i], ranks[j]));
                }
        }
        public void showDeck()
        {
            for(int i = 0; i < deck.Count; i++)
            {
                Console.WriteLine(deck[i].getCard());
            }
        }
        public List<Card> shuffleDeck()
        {
     
        List<Card> shuffledDeck = new List<Card>();
            while(deck.Count > 0) 
            {
                int num = random.Next(deck.Count);
                shuffledDeck.Add(deck[num]);
                deck.RemoveAt(num);
            }
            deck = shuffledDeck;
            return deck;
        }
        public List<Card> removeCard(int index)
        {
            deck.RemoveAt(index);
            return deck;
        }
        public Card drawCard()
        {
            //select random card
            int num = random.Next(deck.Count);
            Card card = deck[num];
            //remove card after drawn
            removeCard(num);
            //return the card
            return card;
        }
    }
}
