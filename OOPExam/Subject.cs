using OOPExam.ExamTypes;
using OOPExam.QuestionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }
        public void CreateExam()
        {
            Console.WriteLine("choose exam type you want to create (1 for practical and 2 for final ):");

            int examtype=getuserinput(1, 2);

            Console.WriteLine("please enter the number of questions you want to crete :");
            int numofquestions = getuserinput(1, 20);

            if(examtype==1)
            {
                SubjectExam = new PracticalExam(DateTime.Now, numofquestions);
            }
            else
            {
                SubjectExam = new FinalExam(DateTime.Now, numofquestions);
            }
            for (int i = 0; i < numofquestions; i++)
            {
                createNewQuestion(i+1);

            }      
        
        }

        private void createNewQuestion(int questionnumber)
        {
            Console.WriteLine($"question  {questionnumber}:");

            if (SubjectExam is FinalExam)
            {
                Console.WriteLine("choose the type of question you want to create (1 for T/F and 2 for MCQ ):");

                int questiontype=getuserinput(1, 2);

                if (questiontype == 1)
                {
                    createTrueFalseQuestion();
                }
                else
                {
                    createMcqQuestion();    

                }
            }
            else
            {
                createMcqQuestion();

            }
        }

        private void createTrueFalseQuestion()
        {
            Console.WriteLine("Enter question header:");
            string header = Console.ReadLine();

            Console.WriteLine("Enter the body of question :");
            string body = Console.ReadLine();

            Console.WriteLine("Enter the marks of question:");
            int marks = getuserinput(1, 100);

            var question=new TrueFalseQuestion(header,body, marks);

            Console.WriteLine("Enter correct answer (1 for True, 2 for False):");
            int rightanswer = getuserinput(1, 2);

            question.RightAnswer = question.AnswerList[rightanswer - 1];


            SubjectExam.Addquestion(question);


        }


        private void createMcqQuestion()
        {
            Console.WriteLine("Enter question header:");
            string header = Console.ReadLine();

            Console.WriteLine("Enter the body of question :");
            string body = Console.ReadLine();

            Console.WriteLine("Enter the marks of question:");
            int marks = getuserinput(1, 100);

            var question = new MCQQuestion(header, body, marks);

            string[] mcqOptions=new string[4];
            for(int i=0; i<mcqOptions.Length; i++)
            {
                Console.WriteLine($"Enter Option : {i+1}");
                mcqOptions[i] = Console.ReadLine();
            }

            question.AddAnswers(mcqOptions);

            Console.WriteLine("Enter number of correct answer (1,2,3,4):");
            int rightanswer = getuserinput(1, 4);

            question.RightAnswer = question.AnswerList[rightanswer - 1];


            SubjectExam.Addquestion(question);


        }

        public int getuserinput(int v1 , int v2)
        {
            int value;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value) && value >= v1 && value <= v2)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"enter valid value between {v1} and {v2}:");
                }
            }


        }
    }
}
