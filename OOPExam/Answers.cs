﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answers(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
            
        }
    }
}
