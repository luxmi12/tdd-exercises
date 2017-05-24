using NUnit.Framework;
using Shouldly;

namespace Tdd.Exercise7.Tests
{
    [TestFixture]
    public class GameShould
    {
        private Game _game;
        private Player _player1;
        private Player _player2;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
            _player1 = new Player();
            _player2 = new Player();
        }

        [Test]
        public void Play_at_least_3_rounds()
        {
            GameResult result = _game.Play(_player1, _player2);
            result.RoundCount.ShouldBeGreaterThanOrEqualTo(3);
        }

        [Test]
        public void Have_a_winner()
        {
            GameResult result = _game.Play(_player1, _player2);
            result.Winner.ShouldNotBeNull();
        }
    }
}