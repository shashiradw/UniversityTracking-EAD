using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversitySystem.core.Model;
using MathNet.Numerics.LinearRegression;
using MathNet.Numerics;

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

        public void addSubjects(Student student)
        {
            student.subjects= _dataManager.AddSubjects();
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

            double total_min = 0;
            double break_min =0;
            foreach (StudySession session in subject.studySessions)
            {
                total_min += session.end_time.TotalMinutes - session.start_time.TotalMinutes;
                break_min = session.breaks.Aggregate(0.0, (sum, b) => sum + b.end_time.TotalMinutes - b.start_time.TotalMinutes);
                total_min -= break_min;
            }

            double c_knowledge = CalculateCumulativeKnowledgeLevel(subject);
            string grade = GetGrade(c_knowledge);

            double study_hours = total_min / 60;

            return new Knowledge(subject.name, study_hours, c_knowledge, grade);
        }

        public double getTotalKnowledge(Subject subject)
        {
            double totalKnowledgeLevel = subject.studySessions.Sum(s => s.currentKnowledge);
            return totalKnowledgeLevel;
        }

        public double calculateKnowledgePercentage(double total_knowledge, int count)
        {
            double maxPossibleKnowledge = count * 10.0;
            double percentage = (total_knowledge / maxPossibleKnowledge) * 100;

            return percentage;
        }

        public double CalculateCumulativeKnowledgeLevel(Subject subject)
        {

            if(subject.studySessions.Count == 0) return 0;

            double totalKnowledgeLevel = getTotalKnowledge(subject);

            double percentage = calculateKnowledgePercentage(totalKnowledgeLevel, subject.studySessions.Count);

            return percentage;
        }

        public PredictModel predictFutureGrades(Subject subject, DateTime date)
        {
            
            // get sessions, sum of currentKnowledge by day
            var knowledgeSumByDay = subject.studySessions
                .GroupBy(session => session.date.Date) 
                .Select(group => new
                    {
                        Date = group.Key,
                        TotalKnowledge = group.Sum(session => session.currentKnowledge)
                    })
                .OrderBy(item => item.Date)
                .ToList();

            double[] dates = new double[knowledgeSumByDay.Count];
            double[] knowledges = new double[knowledgeSumByDay.Count];

            // Populate dates
            for (int i = 0; i < knowledges.Length; i++)
            {
                dates[i] = knowledgeSumByDay[i].Date.ToOADate(); // DateTime to numeric
                knowledges[i] = knowledgeSumByDay[i].TotalKnowledge;
            }

            try
            {
                // Perform linear regression
                var (intercept, slope) = Fit.Line(dates, knowledges);

                double newDate = date.ToOADate();
                double predictedKnowledge = slope * newDate + intercept;

                ///Calculate the grade
                //1) Get total current knowledge
                double total_knowledge = getTotalKnowledge(subject);

                //2) Add predicted value
                total_knowledge += predictedKnowledge;

                // get the percentage
                double percentage = calculateKnowledgePercentage(total_knowledge, subject.studySessions.Count + 1);

                // Get the grade
                string grade = GetGrade(percentage);

                return new PredictModel(subject.name, predictedKnowledge, grade);
            }
            catch (Exception ex) { 
                return null;
            }
        }


        public List<StudySession> filterSessionsByDateRange(Subject subject, DateTime start_date, DateTime end_date)
        {
            if(subject == null || subject.studySessions == null){ 
                return new List<StudySession>();
            }

            List<StudySession> filteredSessions = new List<StudySession>();

            foreach (StudySession session in subject.studySessions)
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

