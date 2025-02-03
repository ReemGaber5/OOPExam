using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public abstract class Exam
    {
        public DateTime ExamTime { get; set; }
        public int NumOFQuestions { get; set; }

        public List<Question> questions { get; set; }

        public int TotalMarks { get; set; }
        public int StudentMarks { get; set; }

        protected Exam(DateTime examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            NumOFQuestions = numberOfQuestions;
            questions = new List<Question>();
            
        }
        public abstract void ShowExam();

        public void Addquestion(Question q)
        {
            if (questions.Count < NumOFQuestions)
            {
                questions.Add(q);
                TotalMarks += q.Mark;
            }
        }

        protected List<Answers> GetAnswers()
        {
            var userAnswers = new List<Answers>();

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}:");
                Console.WriteLine(questions[i].Header);
                Console.WriteLine(questions[i].Body);

                for (int j = 0; j < questions[i].AnswerList.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {questions[i].AnswerList[j].AnswerText}");
                }

                Console.Write("\nYour answer (enter number): ");
                int answerIndex;
                while (!int.TryParse(Console.ReadLine(), out answerIndex) ||
                       answerIndex < 1 ||
                       answerIndex > questions[i].AnswerList.Length)
                {
                    Console.Write($"Please enter a number between 1 and {questions[i].AnswerList.Length}: ");
                }

                userAnswers.Add(questions[i].AnswerList[answerIndex - 1]);
            }

            return userAnswers;
        }

    }
}
