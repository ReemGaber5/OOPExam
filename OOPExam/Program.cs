using OOPExam.ExamTypes;
using System.Diagnostics;

namespace OOPExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject(10, "C#");
            sub1.CreateExam();

            Console.Clear();
            Console.WriteLine("Do you want to start the exam? (y/n)");

            if (char.Parse(Console.ReadLine().ToLower()) == 'y')
            {
                Console.Clear();

                Stopwatch sw = new Stopwatch();
                sw.Start();

                sub1.SubjectExam.ShowExam();

                sw.Stop();
                Console.WriteLine($"\nThe elapsed time = {sw.Elapsed}");
            }
        }
    }
}
