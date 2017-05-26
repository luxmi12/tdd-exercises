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
            var winner = _round.Play(player1, player2);

            IPlayer winningPlayer = null;
            if (winner == Winner.Player1)
                winningPlayer = player1;
            else if (winner == Winner.Player2)
                winningPlayer = player2;

            return new GameResult {WinningPlayer = winningPlayer};
        }
    }
}