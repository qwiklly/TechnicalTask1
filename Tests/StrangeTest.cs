using TechnicalTask1.Constants;
using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;

namespace TechnicalTask1.Tests
{
	public class StrangeTest : ITest
    {
        public Result Evaluate(Candidate candidate)
        {
            if (candidate.Name.StartsWith("П"))
                return new Result(ConstantsMarks.Good, "");
            if (candidate.Age > 68)
                return new Result(ConstantsMarks.Satisfactory, "Возраст кандидата больше 68 лет");
            return new Result(ConstantsMarks.Unsatisfactory, "Имя кандидата не начинается с буквы «П» и возраст кандидата больше 68 лет");
        }
    }
}
