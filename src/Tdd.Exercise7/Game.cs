using System;

namespace Tdd.Exercise7
{
    public class Game
    {
        public GameResult Play(Player player1, Player player2)
        {
            return new GameResult
            {
                Winner = player1
            };
        }
    }
}