using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class PredictModel
    {
        public string subject { get; set; }
        public double c_knowledge_level { get; set; }
        public string grade {  get; set; }

        public PredictModel() { }
        public PredictModel(string subject, double c_knowledge_level, string grade)
        {
            this.subject = subject;
            this.c_knowledge_level = c_knowledge_level;
            this.grade = grade;
        }
    }
}
