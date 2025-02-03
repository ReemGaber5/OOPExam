﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.ExamTypes
{
    public class FinalExam : Exam
    {
        private List<Answers> answers { get; set; }

        public FinalExam(DateTime examtime, int numberofquestions) : base(examtime, numberofquestions)
        {
            answers = new List<Answers>();
        }

        public override void ShowExam()
        {
            Console.WriteLine($"Total Questions: {NumOFQuestions}");
            Console.WriteLine($"Total Marks: {TotalMarks}");

            answers = GetAnswers();
            CalculateTotalGrade();
            ShowQuestionsAndGrade();
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
        public void ShowQuestionsAndGrade()
        {
            Console.WriteLine("\n=== Exam Results ===");

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questions[i].Header}");
                Console.WriteLine($"Your Answer: {answers[i].AnswerText}");
                Console.WriteLine($"Correct Answer: {questions[i].RightAnswer.AnswerText}");

                if (answers[i].AnswerId == questions[i].RightAnswer.AnswerId)
                {
                    Console.WriteLine($"Marks: {questions[i].Mark}");
                }
                else
                {
                    Console.WriteLine("Marks: 0");
                }
            }

            Console.WriteLine($"\nTotal Grade: {StudentMarks} out of {TotalMarks}");
       
        }
    }

}
