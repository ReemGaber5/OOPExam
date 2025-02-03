using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.ExamTypes
{
    public class PracticalExam : Exam
    {
        private List<Answers> answers { get; set; }

        public PracticalExam(DateTime examtime, int numberofquestions) : base(examtime, numberofquestions)
        {
            answers = new List<Answers>();
        }

        public override void ShowExam()
        {
            Console.WriteLine("\n=== Practical Exam ===");
            Console.WriteLine($"Total Questions: {NumOFQuestions}");
            Console.WriteLine($"Total Marks: {TotalMarks}");
            Console.WriteLine("=====================");

            answers = GetAnswers();
            CalculateTotalGrade();
            ShowRightAnswers();
        }

        private void CalculateTotalGrade()
        {
            StudentMarks = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (answers[i].AnswerId == questions[i].RightAnswer.AnswerId)
                {
                    StudentMarks += questions[i].Mark;
                }
            }
        }

        private void ShowRightAnswers()
        {
            Console.WriteLine("=== Practical Exam Results ===");

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questions[i].Header}");
                Console.WriteLine($"Your Answer: {answers[i].AnswerText}");
                Console.WriteLine($"Correct Answer: {questions[i].RightAnswer.AnswerText}");
            }

            Console.WriteLine($"\nTotal Grade: {StudentMarks} out of {TotalMarks}");
            
        }
    }
}

    
