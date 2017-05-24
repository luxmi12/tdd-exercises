using NUnit.Framework;
using Shouldly;

namespace Tdd.Exercise7.Tests
{
    [TestFixture]
    public class GameShould
    {
        [Test]
        public void Play_at_least_3_rounds()
        {
            var game = new Game();
            var player1 = new Player();
            var player2 = new Player();
            GameResult result = game.Play(player1, player2);
            result.RoundCount.ShouldBeGreaterThanOrEqualTo(3);
        }
    }
}