using System;

namespace ImmutableTennisKata.Scores
{
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
}