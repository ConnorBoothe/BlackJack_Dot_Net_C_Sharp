using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class ScoreCard
    {
        Game game = new Game();
        public int user_wins = 0;
        public int dealer_wins = 0;
        public void incrementWins(String winner)
        {
            if(winner == "user")
            {
                user_wins++;
            }
            else if(winner == "dealer")
            {
                dealer_wins++;
            }
        }
        public void GamePlay()
        {
            String playAgain = "y";
            while(playAgain == "y")
            {
                var winner = game.Play();
                Console.WriteLine("Winner: " + winner);
                incrementWins(winner);
                Console.WriteLine(showScoreCard());
                Console.WriteLine("Would you like to play again(y or n)?");
                playAgain = Console.ReadLine().ToLower();
                game.resetGame();
            }
            
        }
        public String showScoreCard()
        {
            return "User wins: " + user_wins + "\nDealer Wins: " + dealer_wins;
        }
    }
}
