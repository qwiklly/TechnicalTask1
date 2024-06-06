using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class HeightTest : ITest
	{
		public Result Evaluate(Candidate candidate)
		{
			if (candidate.Height > 190 || candidate.Height < 160)
				return new Result(ConstantsMarks.Unsatisfactory, "Рост кандидата больше 190 см или меньше 160 см");
			if (candidate.Height >= 160 && candidate.Height < 170 || candidate.Height > 185 && candidate.Height <= 190)
				return new Result(ConstantsMarks.Satisfactory, "Рост кандидата в диапазоне [160-170) или (185-190]");
			return new Result(ConstantsMarks.Good, "");
		}
	}
}
