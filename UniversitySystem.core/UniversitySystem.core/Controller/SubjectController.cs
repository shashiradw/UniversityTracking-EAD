using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversitySystem.core.Model;

namespace UniversitySystem.core.Services
{
    public class SubjectController
    {
        private DataManagerDB _dataManager;

        public SubjectController() {
            _dataManager = DataManagerDB.Instance;
        }

        public Subject createSubject(int Id, string Name)
        {
            return new Subject(Id, Name);
        }

        public void addSubject(Subject subject)
        {
            _dataManager.student.subjects.Add(subject);
        }

        public List<Subject> getAllSubjects() 
        { 
            return _dataManager.student.subjects;
        }

        public string GetGrade(double percentage)
        {
            if (percentage >= 75) return "A";
            if (percentage >= 60) return "B";
            if (percentage >= 50) return "C";
            if (percentage >= 35) return "S";
            return "W";
        }

        public List<Knowledge> getKnowledges()
        {
            if (_dataManager.subjects == null) return null;

            List<Knowledge> list = new List<Knowledge>();
            foreach (Subject subject in _dataManager.subjects)
            {
                list.Add(getKnowledge(subject));
            }
            return list;
        }

        public Knowledge getKnowledge(Subject subject) 
        {
            if(subject == null) return null;

            TimeSpan study_hours = TimeSpan.Zero; 
            foreach (StudySession session in subject.sessions)
            {
                study_hours += session.end_time - session.start_time;
                TimeSpan breakHours = session.breaks.Aggregate(TimeSpan.Zero, (sum, b) => sum + (b.end_time - b.start_time));
                study_hours -= breakHours;
            }

            double c_knowledge = CalculateCumulativeKnowledgeLevel(subject);
            string grade = GetGrade(c_knowledge);

            return new Knowledge(subject.name, study_hours, c_knowledge, grade);
        }

        public double CalculateCumulativeKnowledgeLevel(Subject subject)
        {

            if(subject.sessions.Count == 0) return 0;

            double totalKnowledgeLevel = subject.sessions.Sum(s => s.currentKnowledge);
            double maxPossibleKnowledge = subject.sessions.Count * 10.0;
            double percentage = (totalKnowledgeLevel / maxPossibleKnowledge) * 100;

            return percentage;
        }


        public List<StudySession> filterSubjectByDate(Subject subject, DateTime start_date, string filter_mode)
        {
            List<StudySession> filteredSessions = new List<StudySession>();

            foreach (StudySession session in subject.sessions)
            {
               
                if (filter_mode == "Weekly")
                {
                    if (session.date >= start_date && session.date < start_date.AddDays(7))
                    {
                        filteredSessions.Add(session);
                    }
                }
                else if (filter_mode == "Day")
                {
                    if (session.date.Date == start_date.Date)
                    {
                        filteredSessions.Add(session);
                    }
                }
            }
            return filteredSessions;
        }

        public List<StudySession> filterSessionsByDateRange(Subject subject, DateTime start_date, DateTime end_date)
        {
            if(subject == null || subject.sessions == null){ 
                return new List<StudySession>();
            }

            List<StudySession> filteredSessions = new List<StudySession>();

            foreach (StudySession session in subject.sessions)
            {
                if( session.date.Date >= start_date.Date && session.date.Date <= end_date.Date)
                {
                    filteredSessions.Add(session);
                }
            }
            return filteredSessions;
        }
    }
}

