using System.Collections.Generic;
using System.Linq;

namespace ImmutableTennisKata
{
	public class Game
	{
		private readonly string _score;

		private readonly Dictionary<string, string[]> _scoreTree = new Dictionary<string, string[]>
			{
				{"Love-Love", new[] {"15-Love", "Love-15"}},
				{"Love-15", new[] {"15-15", "Love-30"}},
				{"Love-30", new[] {"15-30", "Love-40"}},
				{"Love-40", new[] {"15-40", "Player 2 Game"}},
				{"15-Love", new[] {"30-Love", "15-15"}},
				{"15-15", new[] {"30-15", "15-30"}},
				{"15-30", new[] {"30-30", "15-40"}},
				{"15-40", new[] {"30-40", "Player 2 Game"}},
				{"30-Love", new[] {"40-Love", "30-15"}},
				{"30-15", new[] {"40-15", "30-30"}},
				{"30-30", new[] {"40-30", "30-40"}},
				{"30-40", new[] {"Deuce", "Player 2 Game"}},
				{"40-Love", new[] {"Player 1 Game", "40-15"}},
				{"40-15", new[] {"Player 1 Game", "40-30"}},
				{"40-30", new[] {"Player 1 Game", "Deuce"}},
				{"Deuce", new[] {"Advantage Player 1", "Advantage Player 2"}},
				{"Advantage Player 1", new[] {"Player 1 Game", "Deuce"}},
				{"Advantage Player 2", new[] {"Deuce", "Player 2 Game"}},
			};

		public Game()
		{
			_score = _scoreTree.First().Key;
		}

		public Game(string score)
		{
			_score = score;
		}

		public string Score
		{
			get { return _score; }
		}

		public Game PlayerOneScores()
		{
			return new Game(_scoreTree[_score][0]);
		}

		public Game PlayerTwoScores()
		{
			return new Game(_scoreTree[_score][1]);
		}
	}
}