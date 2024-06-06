namespace TechnicalTask1.Models
{
	public class Candidate(string name, int weight, int height, int age, double vision, string[] issues)
    {
        public string Name { get; } = name;
        public int Weight { get; } = weight;
        public int Height { get; } = height;
        public int Age { get; } = age;
        public double Vision { get; } = vision;
        public string[] Issues { get; } = issues;
    }
}
