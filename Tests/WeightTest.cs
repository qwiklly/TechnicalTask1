using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class WeightTest : ITest
	{
		public Result Evaluate(Candidate candidate)
		{
			if (candidate.Weight > 100 || candidate.Weight < 70)
				return new Result(ConstantsMarks.Unsatisfactory, "Вес кандидата больше 100 кг или меньше 70 кг");
			if (candidate.Weight >= 70 && candidate.Weight < 75 || candidate.Weight > 90 && candidate.Weight <= 100)
				return new Result(ConstantsMarks.Satisfactory, "Вес кандидата в диапазоне [70-75) или (90-100]");
			return new Result(ConstantsMarks.Good, "");
		}
	}
}
