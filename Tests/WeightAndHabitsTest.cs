using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class WeightAndHabitsTest : ITest
	{
		public Result Evaluate(Candidate candidate)
		{
			if (candidate.Issues.Contains("курение") && candidate.Issues.Contains("простуда") && (candidate.Weight > 120 || candidate.Weight < 60))
				return new Result(ConstantsMarks.Unsatisfactory, "Кандидат курит, у кандидата простуда и/или вирусы, и его вес больше 120 кг или меньше 60 кг");
			if (candidate.Issues.Contains("простуда") && candidate.Weight > 110)
				return new Result(ConstantsMarks.Satisfactory, "Кандидат не удовлетворяет критерию из неудовлетворительно, и у него есть простуда и/или вирусы, и его вес больше 110 кг");
			return new Result(ConstantsMarks.Good, "");
		}
	}
}
