using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class Subject
    {
        public int id {  get; set; }
        public string name { get; set; }

        public List<Session> sessions { get; set; }

        public List<KnowledgeAssessment> assessment { get; set; }

        public Student student { get; set; }



        public Subject() { }

        public Subject(string name, List<Session> sessions, List<KnowledgeAssessment> assessment, Student student)
        {
            name = name;
            sessions = sessions;
            assessment = assessment;
            student = student;
        }



    }
}
