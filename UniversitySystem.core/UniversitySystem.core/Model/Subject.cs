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
        public List<StudySession> studySessions { get; set; }
        public Subject() { }

        public Subject(int Id, string Name) 
        {
            id = Id;
            name = Name;
            studySessions = new List<StudySession>();
        }

    }
}
