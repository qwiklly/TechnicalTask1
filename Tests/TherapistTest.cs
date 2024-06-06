using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class TherapistTest : ITest
	{
		public Result Evaluate(Candidate candidate)
		{
			int diseasesCount = candidate.Issues.Count(issue => new[] { "насморк", "бронхит", "вирус", "аллергия", "ангина", "бессонница" }.Contains(issue));

			if (diseasesCount > 3)
				return new Result(ConstantsMarks.Unsatisfactory, "Больше 3 болезней");
			if (diseasesCount == 3)
				return new Result(ConstantsMarks.Satisfactory, "3 болезни");
			return new Result(ConstantsMarks.Good, "");
		}
	}
}
