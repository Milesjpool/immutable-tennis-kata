namespace ImmutableTennisKata
{
	public class Game
	{
		private readonly string _playerOneScore;
		private readonly string _playerTwoScore;

		public Game(string playerOneScore = "Love", string playerTwoScore = "Love")
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
			if (string.Equals(_playerOneScore, "Love"))
				return new Game("15", _playerTwoScore);
			return new Game("30", _playerTwoScore);
		}
	}
}