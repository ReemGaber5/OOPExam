using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.ExamTypes
{
    public class PracticalExam:Exam
    {
        public PracticalExam(DateTime examtime, int numberofquestions) : base(examtime, numberofquestions)
        {
        }
    }
}
