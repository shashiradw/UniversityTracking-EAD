using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core
{
    public class DataStore
    {
        private static DataStore _instance;

        private static readonly object _lock = new object();
        public Student student { get; set; }
        public List<Subject> subjects { get; set; }
        public List<StudySession> studySessions { get; set; }
        public List<BreakSession> breakSessions { get; set; }

        private DataStore()
        {
            student = new Student();
            studySessions = new List<StudySession>();
            subjects = new List<Subject>();
            breakSessions = new List<BreakSession>();
        }

        public static DataStore Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DataStore();
                    }
                }
                return _instance;
            }
        }

        public Student GetStudent()
        {
            return student;
        }

        public void SetStudentName(string username)
        {
            student.name = username;
        }

        public List<Subject> GetAllSubjects()
        {
            return subjects;
        }

        public List<StudySession> GetAllStudySessions()
        {
            return studySessions;
        }

        public List<BreakSession> GetAllBreakSessions()
        {
            return breakSessions;
        }

        public List<Subject> AddSubjects()
        {
            Subject sub1= new Subject(1, "EAD");
            Subject sub2 = new Subject(2, "UI/UX");
            Subject sub3 = new Subject(3, "Maths");

            subjects.Add(sub1);
            subjects.Add(sub2);
            subjects.Add(sub3);

            return subjects;
        }

    }

}
