using TechnicalTask1.Interfaces;
using TechnicalTask1.Models;
using TechnicalTask1.Tests;
using TechnicalTask1.Constants;

namespace TechnicalTask1
{
	public class Program
	{
		static void Main()
		{
			while (true)
			{
				try
				{
					Console.WriteLine("Введите имя кандидата:");
					string? name = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(name)) throw new Exception("Имя не может быть пустым.");

					Console.WriteLine("Введите вес кандидата (кг):");
					int weight = Convert.ToInt32(Console.ReadLine()); 
					if (weight <= 0) throw new Exception("Вес должен быть больше 0.");

					Console.WriteLine("Введите рост кандидата (см):");
					int height = Convert.ToInt32(Console.ReadLine());
					if (height <= 0) throw new Exception("Рост должен быть больше 0.");

					Console.WriteLine("Введите возраст кандидата (лет):");
					int age = Convert.ToInt32(Console.ReadLine());
					if (age <= 0) throw new Exception("Возраст должен быть больше 0.");

					Console.WriteLine("Введите зрение кандидата:");
					double vision = Convert.ToDouble(Console.ReadLine());
					if (vision < 0 || vision > 1) throw new Exception("Зрение должно быть в диапазоне от 0 до 1.");

					Console.WriteLine("Введите список вредных привычек и болезней (через пробел):");
					string[] issues = Console.ReadLine()!.Split(' ').Select(issue => issue.ToLower()).ToArray();

					Candidate candidate = new(name, weight, height, age, vision, issues);

					var tests = new List<ITest>
				{
					new WeightTest(),
					new HeightTest(),
					new AgeTest(),
					new VisionTest(),
					new SmokingTest(),
					new TherapistTest(),
					new PsychologistTest(),
					new WeightAndHabitsTest(),
					new StrangeTest(),
					new MathTest()
				};

					var results = tests.Select(test => test.Evaluate(candidate)).ToList();

					if (results.Any(result => result.Mark == ConstantsMarks.Unsatisfactory))
					{
						Console.WriteLine($"Кандидат {candidate.Name} не прошел тестирование. Проблемы:");
						foreach (var result in results.Where(result => result.Mark != ConstantsMarks.Satisfactory && result.Mark != ConstantsMarks.Good))
						{
							Console.WriteLine($"* {result.Reason} ({result.Mark})");
						}
					}
					else if (results.Count(result => result.Mark == ConstantsMarks.Satisfactory) >= 3)
					{
						Console.WriteLine($"Кандидат {candidate.Name} не прошел тестирование. Проблемы:");
						foreach (var result in results.Where(result => result.Mark == ConstantsMarks.Satisfactory && result.Mark != ConstantsMarks.Good))
						{
							Console.WriteLine($"* {result.Reason} ({result.Mark})");
						}
					}
					else
					{
						Console.WriteLine($"Кандидат {candidate.Name} подходит");
					}

					Console.WriteLine("Хотите протестировать другого кандидата? (да/нет)");
					if (!Console.ReadLine()!.Equals("да", StringComparison.CurrentCultureIgnoreCase))
					{
						break;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Ошибка: {ex.Message}");
				}
			}
		}
	}
}

