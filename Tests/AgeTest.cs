using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;
using TechnicalTask1.Constants;

namespace TechnicalTask1.Tests
{
    public class AgeTest : ITest
	{
		public Result Evaluate(Candidate candidate)
		{
			if (candidate.Age > 37 || candidate.Age < 23)
				return new Result(ConstantsMarks.Unsatisfactory, "Возраст кандидата больше 37 лет или меньше 23 лет");
			if (candidate.Age >= 23 && candidate.Age < 25 || candidate.Age > 35 && candidate.Age <= 37)
				return new Result(ConstantsMarks.Satisfactory, "Возраст кандидата в диапазоне [23-25) или (35-37]");
			return new Result(ConstantsMarks.Good, "");
		}
	}
}
