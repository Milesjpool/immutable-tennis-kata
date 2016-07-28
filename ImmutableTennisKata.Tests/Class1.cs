using NUnit.Framework;

namespace ImmutableTennisKata.Tests
{
	[TestFixture]
    public class GameTests
    {
		[Test]
		public void AGameStartsAtLoveLove()
		{
			var game = new Game();

			Assert.That(game.Score, Is.EqualTo("Love-Love"));
		}
    }

	public class Game
	{
		public string Score
		{
			get { return "Love-Love"; }
		}
	}
}
