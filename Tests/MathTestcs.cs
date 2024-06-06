using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class MathTest : ITest
    {
        public Result Evaluate(Candidate candidate)
        {
            if (candidate.Height % 3 == 0 && candidate.Issues.Contains("насморк"))
                return new Result(ConstantsMarks.Unsatisfactory, "Рост делится нацело на 3, и у кандидата насморк");
            if (candidate.Height % 2 == 0)
                return new Result(ConstantsMarks.Good, "");
            return new Result(ConstantsMarks.Satisfactory, "Рост не делится нацело на 2 и не удовлетворяет критерию из неудовлетворительно");
        }
    }
}
