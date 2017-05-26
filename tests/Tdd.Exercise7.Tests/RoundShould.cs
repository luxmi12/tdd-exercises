
using NSubstitute;
using NUnit.Framework;
using Shouldly;

namespace Tdd.Exercise7.Tests
{
    [TestFixture]
    public class RoundShould
    {
        private Round _round;
        private IPlayer _player1;
        private IPlayer _player2;

        [SetUp]
        public void SetUp()
        {
            _round = new Round();
            _player1 = Substitute.For<IPlayer>();
            _player2 = Substitute.For<IPlayer>();
        }

        [Test]
        public void Decide_scissors_beats_paper()
        {
            _player1.RevealHand().Returns(Hand.Paper);
            _player2.RevealHand().Returns(Hand.Scissors);
            var winner = _round.Play(_player1, _player2);
            winner.ShouldBe(Winner.Player2);
        }
    }

}