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
            int roundCount = 0;

            while (roundCount < 3 || player1Wins == 0 && player2Wins == 0)
            {
                roundCount++;

                var winner = _round.Play(player1, player2);
                if (winner == Winner.Player1)
                    player1Wins++;
                else if (winner == Winner.Player2)
                    player2Wins++;
            }

            IPlayer winningPlayer  = player1Wins > player2Wins ? player1 : player2;

            return new GameResult(roundCount, winningPlayer);
        }
    }
}