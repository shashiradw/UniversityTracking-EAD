using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{

    public class Knowledge
    {
        public string subject { get; set; }
        public TimeSpan study_hours { get; set; }
        public double c_knowledge_level { get; set; }
        public string grade {  get; set; }  

        public Knowledge() { }  
        public Knowledge(string subject, TimeSpan study_hours, double c_knowledge_level, string grade)
        {
            this.subject = subject;
            this.study_hours = study_hours;
            this.c_knowledge_level = c_knowledge_level;
            this.grade = grade;
        }
    }
}
