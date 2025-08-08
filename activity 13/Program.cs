internal class Program
{
    private static void Main(string[] args)
    {
        List<string> students = new List<string> { "Tom", "Jerry", "Mickey" };
        List<int> scores = new List<int> { 85, 92, 76 };

        var sorted = students.Zip(scores, (s, sc) => new { Name = s, Score = sc })
                             .OrderByDescending(x => x.Score)
                             .Take(3)
                             .ToList();

        Console.WriteLine("Top Performers:");
        foreach (var student in sorted)
        {
            Console.WriteLine($"{student.Name}: {student.Score}");
        }
    }
}