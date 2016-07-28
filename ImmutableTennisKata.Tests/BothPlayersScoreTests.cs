using NUnit.Framework;

namespace ImmutableTennisKata.Tests
{
	[TestFixture]
	public class BothPlayersScoreTests
	{
		[Test]
		public void ScoreIs1515AfterTwoPoints()
		{
			var game = new Game()
				.PlayerOneScores()
				.PlayerTwoScores();

			Assert.That(game.Score, Is.EqualTo("15-15"));
		}

		[Test]
		public void ScoreIs3030AfterFourPoints()
		{
			var game = new Game()
				.PlayerOneScores()
				.PlayerTwoScores()
				.PlayerTwoScores()
				.PlayerOneScores();

			Assert.That(game.Score, Is.EqualTo("30-30"));
		}

		[Test]
		public void ScoreIsDeuceAfterPlayer1WinsSixthPoint()
		{
			var game = new Game("30-40")
				.PlayerOneScores();

			Assert.That(game.Score, Is.EqualTo("Deuce"));
		}


		[Test]
		public void ScoreIsDeuceAfterPlayer2WinsSixthPoint()
		{
			var game = new Game("40-30")
				.PlayerTwoScores();

			Assert.That(game.Score, Is.EqualTo("Deuce"));
		}

		[Test]
		public void AdvantagePlayer1AfterDeuce()
		{
			var game = new Game("Deuce")
				.PlayerOneScores();

			Assert.That(game.Score, Is.EqualTo("Advantage Player 1"));
		}

		[Test]
		public void Player1WinsAfterAdvantage()
		{
			var game = new Game("Advantage Player 1")
				.PlayerOneScores();

			Assert.That(game.Score, Is.EqualTo("Player 1 Game"));
		}

		[Test]
		public void AdvantagePlayer2AfterDeuce()
		{
			var game = new Game("Deuce")
				.PlayerTwoScores();

			Assert.That(game.Score, Is.EqualTo("Advantage Player 2"));
		}

		[Test]
		public void Player2WinsAfterAdvantage()
		{
			var game = new Game("Advantage Player 2")
				.PlayerTwoScores();

			Assert.That(game.Score, Is.EqualTo("Player 2 Game"));
		}

		[Test]
		public void BackToDeuceAfterPlayer2LosesAdvantage()
		{
			var game = new Game("Advantage Player 2")
				.PlayerOneScores();

			Assert.That(game.Score, Is.EqualTo("Deuce"));
		}

		[Test]
		public void BackToDeuceAfterPlayer1LosesAdvantage()
		{
			var game = new Game("Advantage Player 1")
				.PlayerTwoScores();

			Assert.That(game.Score, Is.EqualTo("Deuce"));
		}
	}
}