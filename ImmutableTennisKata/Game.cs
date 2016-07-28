using System;

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

		public Game(IScore playerOneScore, IScore playerTwoScore)
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
			if (_playerOneScore.GetType() == typeof (Love))
				return new Game(new Fifteen(), _playerTwoScore);
			if (_playerOneScore.GetType() == typeof (Fifteen))
				return new Game(new Thirty(), _playerTwoScore);
			return new Game(new Forty(), _playerTwoScore);
		}
	}


	public class Forty : IScore
	{
		public override string ToString()
		{
			return "40";
		}
	}

	public class Thirty : IScore
	{
		public override string ToString()
		{
			return "30";
		}
	}

	public class Fifteen : IScore
	{
		public override string ToString()
		{
			return "15";
		}
	}

	public class Love : IScore
	{
		public override string ToString()
		{
			return "Love";
		}
	}

	public interface IScore
	{
	}
}