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
			return new Game(_playerOneScore.AddOne(), _playerTwoScore);
		}
	}


	public class Forty : IScore
	{
		public override string ToString()
		{
			return "40";
		}

		public IScore AddOne()
		{
			throw new NotImplementedException();
		}
	}

	public class Thirty : IScore
	{
		public override string ToString()
		{
			return "30";
		}

		public IScore AddOne()
		{
			return new Forty();
		}
	}

	public class Fifteen : IScore
	{
		public override string ToString()
		{
			return "15";
		}

		public IScore AddOne()
		{
			return new Thirty();
		}
	}

	public class Love : IScore
	{
		public override string ToString()
		{
			return "Love";
		}

		public IScore AddOne()
		{
			return new Fifteen();
		}
	}

	public interface IScore
	{
		IScore AddOne();
	}
}