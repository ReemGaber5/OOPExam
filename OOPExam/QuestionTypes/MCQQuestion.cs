using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.QuestionTypes
{
    public class MCQQuestion:Question
    {
        public MCQQuestion(string header, string body, int mark) : base(header, body, mark)
        {
            AnswerList = new Answers[4];
           
        }

        public void AddAnswers(string[] answers)
        {
            if(answers.Length!=4)
            {
                throw new Exception("you must have 4 answers for mcq questions");
            }
            for (int i = 0; i <4; i++)
            {
                AnswerList[i] = new Answers(i + 1, answers[i]);
            }
        }

       
    }
}
