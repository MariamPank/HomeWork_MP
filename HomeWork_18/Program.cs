namespace HomeWork_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student { Name = "Ana", Score = 92 },
                new Student { Name = "Luka", Score = 75 },
                new Student { Name = "Nino", Score = 88 },
                new Student { Name = "Giorgi", Score = 61 },
                new Student { Name = "Tamar", Score = 99 }
            };

            string topStudent = Student.HighScoreStudent(students, s => s.Score);
            Console.WriteLine("Task #1");
            Console.WriteLine($"Student with the highest score: {topStudent}");
            Console.WriteLine();

            Console.WriteLine("Task #2");
            double avScore = Student.AverageScore(students, s => s.Score);
            Console.WriteLine($"Average score: {avScore}");
            Console.WriteLine();

            Console.WriteLine("Task #3");
            var grades = Student.TranslateScore(students, s => s.Score.ToString());
            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("Task #4");
            Student.UpdateScore(students, s => 
            {
                if (s.Name == "Nino")
                    s.Score = 51;
            });

            Console.WriteLine("Task #5");
            Student.UpdateScore(students, s=> Console.WriteLine($"Name - {s.Name}, Score - {s.Score}"));
            Console.WriteLine();

            Console.WriteLine("Task #6");
            Student.AddStudents(students, list =>
            {
                list.Add(new Student { Name = "Natia", Score = 87 });
            });


            Console.WriteLine("Updated student list:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Score}");
            }

        }
    }
}
