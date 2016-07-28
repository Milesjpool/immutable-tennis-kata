namespace ImmutableTennisKata.Scores
{
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
}