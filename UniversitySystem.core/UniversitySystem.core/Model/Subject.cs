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
        public List<StudySession> sessions { get; set; }
        public List<KnowledgeAssessment> assessment { get; set; }
        public Subject() { }

        public Subject(int Id, string Name) 
        {
            id = Id;
            name = Name;
        }

        public Subject(string Name, List<StudySession> Sessions, List<KnowledgeAssessment> Assessment)
        {
            name = Name;
            sessions = Sessions;
            assessment = Assessment;
        }



    }
}
