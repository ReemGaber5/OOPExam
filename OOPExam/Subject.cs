﻿using System;
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
    }
}
