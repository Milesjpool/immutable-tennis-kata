using NUnit.Framework;

namespace ImmutableTennisKata.Tests
{
	[TestFixture]
	public class PlayerTwoScoresTests
	{
		[Test]
		public void ScoreIsLove15AfterOnePoint()
		{
			var game = new Game()
				.PlayerTwoScores();

			Assert.That(game.Score, Is.EqualTo("Love-15"));
		}

		[Test]
		public void ScoreIsLove30AfterTwoPoints()
		{
			var game = new Game()
				.PlayerTwoScores()
				.PlayerTwoScores();

			Assert.That(game.Score, Is.EqualTo("Love-30"));
		}

		[Test]
		public void ScoreIsLove40AfterThreePoints()
		{
			var game = new Game()
				.PlayerTwoScores()
				.PlayerTwoScores()
				.PlayerTwoScores();

			Assert.That(game.Score, Is.EqualTo("Love-40"));
		}
	}
}