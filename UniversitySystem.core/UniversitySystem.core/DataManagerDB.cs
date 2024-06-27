using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core
{
    public class DataManagerDB
    {
        private static DataManagerDB _instance;
        private static readonly object _lock = new object();
        public Student student { get; set; }
        public List<Subject> subjects { get; set; }
        public List<StudySession> studySessions { get; set; }
        public List<BreakSession> breakSessions { get; set; }

        private DataManagerDB()
        {
            student = new Student();
            studySessions = new List<StudySession>();
            subjects = new List<Subject>();
            breakSessions = new List<BreakSession>();

            AddDummyData();
        }

        public static DataManagerDB Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DataManagerDB();
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

        public void AddDummyData()
        {
            // 1
            BreakSession b1 = new BreakSession
            {
                id = 1,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(10).TimeOfDay,
                end_time = DateTime.Today.AddHours(10).AddMinutes(30).TimeOfDay,
            };
            breakSessions.Add(b1);

            BreakSession b2 = new BreakSession
            {
                id = 2,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(11).TimeOfDay,
                end_time = DateTime.Today.AddHours(11).AddMinutes(30).TimeOfDay,
            };
            breakSessions.Add(b2);  

            StudySession s1 = new StudySession
            {
                id = 1,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(9).TimeOfDay,
                end_time = DateTime.Today.AddHours(12).TimeOfDay,
                isRecurring = false,
                breaks = new List<BreakSession>
                    {
                        b1,
                        b2
                    }
            };
            studySessions.Add(s1);

            BreakSession b3 = new BreakSession
            {
                id = 3,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(3).TimeOfDay,
                end_time = DateTime.Today.AddHours(3).AddMinutes(30).TimeOfDay,
            };
            breakSessions.Add(b3);  

            StudySession s2 = new StudySession
            {
                id = 3,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(2).TimeOfDay,
                end_time = DateTime.Today.AddHours(4).TimeOfDay,
                isRecurring = false,
                breaks = new List<BreakSession>
                    {
                        b3
                    }
            };
            studySessions.Add(s2);


            Subject sub1 = new Subject
            {
                id = 1,
                name = "Maths",
                sessions = new List<StudySession>
                {
                    s1,
                    s2
                }
            };
            subjects.Add(sub1);



            //2
            BreakSession b4 = new BreakSession
            {
                id = 4,
                date = DateTime.Today.AddDays(1),
                start_time = DateTime.Today.AddDays(1).AddHours(21).TimeOfDay,
                end_time = DateTime.Today.AddDays(1).AddHours(21).AddMinutes(30).TimeOfDay,
            };
            breakSessions.Add(b4);

            BreakSession b5 = new BreakSession
            {
                id = 5,
                date = DateTime.Today.AddDays(1),
                start_time = DateTime.Today.AddDays(1).AddHours(22).TimeOfDay,
                end_time = DateTime.Today.AddDays(1).AddHours(22).AddMinutes(10).TimeOfDay,
            };
            breakSessions.Add(b5);  

            StudySession s3 = new StudySession
            {
                id = 3,
                date = DateTime.Today.AddDays(1).AddDays(1),
                start_time = DateTime.Today.AddDays(1).AddHours(18).TimeOfDay,
                end_time = DateTime.Today.AddDays(1).AddHours(25).TimeOfDay,
                isRecurring = false,
                breaks = new List<BreakSession>
                    {
                        b4,
                        b5
                    }
            };
            studySessions.Add(s3);

            BreakSession b6 = new BreakSession
            {
                id = 6,
                date = DateTime.Today.AddDays(3),
                start_time = DateTime.Today.AddDays(3).AddHours(10).TimeOfDay,
                end_time = DateTime.Today.AddDays(3).AddHours(10).AddMinutes(30).TimeOfDay,
            };
            breakSessions.Add(b6);

            StudySession s4 = new StudySession
            {
                id = 4,
                date = DateTime.Today.AddDays(3),
                start_time = DateTime.Today.AddDays(3).AddHours(8).TimeOfDay,
                end_time = DateTime.Today.AddDays(3).AddHours(11).TimeOfDay,
                isRecurring = false,
                breaks = new List<BreakSession>
                    {
                        b6
                    }
            };
            studySessions.Add(s4);


            Subject sub2 = new Subject
            {
                id = 2,
                name = "Science",
                sessions = new List<StudySession>
                {
                    s3,
                    s4
                }
            };
            subjects.Add(sub2);

            student.subjects.Add(sub1);
            student.subjects.Add(sub2);
        }


    }


}
