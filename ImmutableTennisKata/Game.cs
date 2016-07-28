using ImmutableTennisKata.Scores;

namespace ImmutableTennisKata
{
	public class Game
	{
		private readonly IScore _playerOneScore;
		private readonly IScore _playerTwoScore;

		public Game()
		{
			_playerOneScore = new Love();
			_playerTwoScore = new Love();
		}

		private Game(IScore playerOneScore, IScore playerTwoScore)
		{
			_playerOneScore = playerOneScore;
			_playerTwoScore = playerTwoScore;
		}

		public string Score
		{
			get { return _playerOneScore + "-" + _playerTwoScore; }
		}

		public Game PlayerOneScores()
		{
			return new Game(_playerOneScore.AddOne(), _playerTwoScore);
		}

		public Game PlayerTwoScores()
		{
			return new Game(_playerOneScore, _playerTwoScore.AddOne());
		}
	}
}