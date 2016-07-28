using NUnit.Framework;

namespace ImmutableTennisKata.Tests
{
	[TestFixture]
	public class PlayerOneScoresTests
	{
		[Test]
		public void ScoreIs15LoveAfterOnePoint()
		{
			var game = new Game().PlayerOneScores();

			Assert.That(game.Score, Is.EqualTo("15-Love"));
		}

		[Test]
		public void ScoreIs30LoveAfterTwoPoints()
		{
			var game = new Game().PlayerOneScores().PlayerOneScores();

			Assert.That(game.Score, Is.EqualTo("30-Love"));
		}
	}
}
