using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class SmokingTest : ITest
	{
		public Result Evaluate(Candidate candidate)
		{
			if (candidate.Issues.Contains("курение"))
				return new Result(ConstantsMarks.Unsatisfactory, "Кандидат курит");
			return new Result(ConstantsMarks.Good, "");
		}
	}
}
