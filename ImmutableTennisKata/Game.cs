namespace ImmutableTennisKata
{
	public class Game
	{
		private readonly string _score;

		public Game(string score = "Love-Love")
		{
			_score = score;
		}

		public string Score
		{
			get { return _score; }
		}

		public Game PlayerOneScores()
		{
			return new Game("15-Love");
		}
	}
}