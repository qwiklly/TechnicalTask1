using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class PsychologistTest : ITest
	{
		public Result Evaluate(Candidate candidate)
		{
			int diseasesCount = candidate.Issues.Count(issue => new[] { "алкоголизм", "бессонница", "наркомания", "травмы" }.Contains(issue));

			if (diseasesCount > 1)
				return new Result(ConstantsMarks.Unsatisfactory, "Более 1 болезни");
			if (diseasesCount == 1)
				return new Result(ConstantsMarks.Satisfactory, "1 болезнь");
			return new Result(ConstantsMarks.Good, "");
		}
	}
}
