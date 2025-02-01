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
            showQuestion();
        }

        public override void showQuestion()
        {
            AnswerList = new Answers[4];
            for(int i = 0;i< AnswerList.Length;i++)
            {
                AnswerList[i]=new Answers(i+1,$"text{i+1}");
            }
           
        }
    }
}
