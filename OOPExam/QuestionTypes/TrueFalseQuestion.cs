using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.QuestionTypes
{
    public class TrueFalseQuestion:Question
    {
        public TrueFalseQuestion(string header, string body, int mark):base(header, body,mark)
        {
            showQuestion();
        }
        public override void showQuestion()
        {
            AnswerList = new Answers[]
            {
                new Answers(1,"True"),
                new Answers(2,"False"),
            };
        }
    }
}
