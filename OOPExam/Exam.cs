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

        public Question[] questions { get; set; }

        protected Exam(DateTime examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            NumOFQuestions = numberOfQuestions;
            questions = new Question[NumOFQuestions];
            
        }
        public abstract void showExam();
    }
}
