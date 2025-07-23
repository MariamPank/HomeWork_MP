using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18
{
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }


        //1 მაღალი ქულის მქონე სტუდენტის პოვნა
        public static string HighScoreStudent(List<Student> students, Func<Student, int> scoreSelector)
        {
            string maxStudentName = null;
            int maxScore = 0;

            foreach (var student in students)
            {
                int score = scoreSelector(student);
                if (score > maxScore)
                {
                    maxScore = score;
                    maxStudentName = student.Name;
                }
            }

            return maxStudentName;
        }

        //2 საშუალო ქულის გამოთვლა
        public static double AverageScore(List<Student> students, Func<Student, double> scoreSelector)
        {
            double totalScore = 0;
            foreach (var student in students)
            {
                totalScore += scoreSelector(student);
            }
            return totalScore / students.Count;
        }

        //3 გაცემული ქულების გარდაქმნა ახალ სკალაში(მაგ. 0–100 → A/B/C)

        public static Dictionary<string, string> TranslateScore(List<Student> students, Func<Student, string> scoreSelector)
        {

            Dictionary<string, string> scoreToMark = new();

            foreach (var student in students)
            {
                string mark;

                if (student.Score < 81)
                {
                    mark = "C";
                }
                else if (student.Score < 91)
                {
                    mark = "B";
                }
                else
                {
                    mark = "A";
                }
                scoreToMark[student.Name] = mark;
            }
            return scoreToMark;
        }

        //4 სტუდენტების ქულის განახლება
        //5 სიაში სტუდენტების დამატება

        public static void UpdateScore(List<Student> students, Action<Student> action)
        {

            foreach (var student in students)
            {
                action(student);
            }
        }

        //6 სტუდენტების ქულების ლოგირება

        public static void AddStudents(List<Student> students, Action<List<Student>> act) 
        {
                act(students);

        }


    }

}








//5 სიაში სტუდენტების დამატება





//მინიშნება
//გამოიყენე Func<Student, int> დელეგატი ქულების მიღებისთვის
//გამოიყენე Func<List<Student>, double> საშუალო ქულის გამოსათვლელად
//გამოიყენე Func<Student, string> ქულის ასოებში გადასაყვანად:
//გამოიყენე Action<Student> დელეგატი სტუდენტის ქულის განახლებისთვის:
//გამოიყენე Action<Student> დელეგატი სტუდენტის ქულის დაბეჭდვისთვის:
//გამოიყენე Action<List<Student>> დელეგატი სიაში სტუდენტების დამატებისთვის:
