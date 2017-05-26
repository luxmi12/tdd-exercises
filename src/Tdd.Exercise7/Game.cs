namespace Tdd.Exercise7
{
    public class Game
    {
        private readonly Round _round;

        public Game(Round round)
        {
            _round = round;
        }

        public GameResult Play(IPlayer player1, IPlayer player2)
        {
            var player1Wins = 0;
            var player2Wins = 0;

            while (player1Wins < 2 && player2Wins < 2)
            {
                var winner = _round.Play(player1, player2);

                if (winner == Winner.Player1)
                    player1Wins++;
                else if (winner == Winner.Player2)
                    player2Wins++;
            }

            IPlayer winningPlayer = null;

            if (player1Wins == 2)
                winningPlayer = player1;
            else if (player2Wins == 2)
                winningPlayer = player2;

            return new GameResult {WinningPlayer = winningPlayer};
        }
    }
}