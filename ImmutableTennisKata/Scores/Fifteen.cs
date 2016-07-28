namespace ImmutableTennisKata.Scores
{
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
}