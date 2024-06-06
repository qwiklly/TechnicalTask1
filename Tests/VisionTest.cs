using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class VisionTest : ITest
	{
		public Result Evaluate(Candidate candidate)
		{
			if (candidate.Vision < 1)
				return new Result(ConstantsMarks.Unsatisfactory, "Зрение кандидата меньше 1");
			return new Result(ConstantsMarks.Good, "");
		}
	}
}
