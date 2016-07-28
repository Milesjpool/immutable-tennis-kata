using NUnit.Framework;

namespace ImmutableTennisKata.Tests
{
	[TestFixture]
	public class NewGameTests
	{
		[Test]
		public void GameStartsAtLoveLove()
		{
			var game = new Game();

			Assert.That(game.Score, Is.EqualTo("Love-Love"));
		}
	}
}