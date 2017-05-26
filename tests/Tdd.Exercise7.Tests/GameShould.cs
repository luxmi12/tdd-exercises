using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tdd.Exercise7.Tests
{
    [TestFixture]
    public class GameShould
    {
        private Round _round;
        private Game _game;
        private IPlayer _player1;
        private IPlayer _player2;

        [SetUp]
        public void SetUp()
        {
            _round = new Round();
            _game = new Game(_round);

            _player1 = Substitute.For<IPlayer>();
            _player2 = Substitute.For<IPlayer>();
        }

        [Test]
        public void Play_at_least_3_rounds()
        {
            GameResult result = _game.Play(_player1, _player2);
            result.RoundCount.ShouldBeGreaterThanOrEqualTo(3);
        }

        [Test]
        public void Decide_the_winner_based_on_round_results()
        {
            _player1.RevealHand().Returns(Hand.Paper);
            _player2.RevealHand().Returns(Hand.Scissors);

            GameResult result = _game.Play(_player1, _player2);
            result.WinningPlayer.ShouldBe(_player2);
        }
    }
}