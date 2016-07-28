namespace ImmutableTennisKata.Scores
{
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
}