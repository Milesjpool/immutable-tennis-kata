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

	[TestFixture]
	public class PlayerOneScoresTests
	{
		[Test]
		public void ScoreIsThen15Love()
		{
			var game = new Game().PlayerOneScores();

			Assert.That(game.Score, Is.EqualTo("15-Love"));
		}
	}


	public class Game
	{
		private string _score;

		public Game()
		{
			_score = "Love-Love";
		}

		public string Score
		{
			get { return _score; }
		}

		public Game PlayerOneScores()
		{
			_score = "15-Love";
			return this;
		}
	}
}
