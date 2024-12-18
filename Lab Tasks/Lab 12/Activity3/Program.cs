// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

namespace Activity
{

    public class StudentClass
    {
        protected enum GradeLevel
        {
            FirstYear = 1,
            SecondYear,
            ThirdYear,
            FourthYear
        }

        protected class Student
        {
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;

            public int ID { get; set; }

            public GradeLevel Year;

            public List<int> ExamScores { get; set; } = new List<int>();
        }

        protected static List<Student> students = new List<Student>
        {
            new Student{FirstName="Terry",LastName="Adams", ID=120,Year=GradeLevel.SecondYear,ExamScores= new List<int>{99,88,81,71} },
            new Student{FirstName="John",LastName="Doe", ID=121,Year=GradeLevel.FirstYear,ExamScores= new List<int>{85,90,78,92} },
            new Student{FirstName="Jane",LastName="Smith", ID=122,Year=GradeLevel.ThirdYear,ExamScores= new List<int>{88,76,90,85} },
            new Student{FirstName="Emily",LastName="Jones", ID=123,Year=GradeLevel.FourthYear,ExamScores= new List<int>{91,89,85,87} },
            new Student{FirstName="Michael",LastName="Brown", ID=124,Year=GradeLevel.SecondYear,ExamScores= new List<int>{80,70,75,85} },
            new Student{FirstName="Sarah",LastName="Davis", ID=125,Year=GradeLevel.FirstYear,ExamScores= new List<int>{95,92,88,90} },
            new Student{FirstName="David",LastName="Wilson", ID=126,Year=GradeLevel.ThirdYear,ExamScores= new List<int>{78,85,80,82} },
            new Student{FirstName="Laura",LastName="Garcia", ID=127,Year=GradeLevel.FourthYear,ExamScores= new List<int>{89,87,90,91} },
            new Student{FirstName="James",LastName="Martinez", ID=128,Year=GradeLevel.SecondYear,ExamScores= new List<int>{84,82,88,86} },
            new Student{FirstName="Anna",LastName="Rodriguez", ID=129,Year=GradeLevel.FirstYear,ExamScores= new List<int>{92,90,85,88} }
        };

        protected static int GetPercentile(Student student)
        {
            double avg = student.ExamScores.Average();
            return avg > 0 ? (int)avg / 10 : 0;
        }

        public void QuerHighScore(int exam, int score)
        {
            var HighScores = from student in students
                             where student.ExamScores[exam] > score
                             select new { Name = student.FirstName, Score = student.ExamScores[exam] };

            foreach (var highScore in HighScores)
            {
                Console.WriteLine($"Name: {highScore.Name}, Score: {highScore.Score}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentClass studentClass = new StudentClass();
            studentClass.QuerHighScore(0, 90); // Query for scores greater than 90 in the first exam
        }
    }
}
