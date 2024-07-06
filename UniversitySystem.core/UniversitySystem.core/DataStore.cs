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
            AddDummyData(student);
            return subjects;
        }


        public void AddDummyData(Student student)
        {
            Subject sub1 = new Subject(1, "EAD");

            // Sub 1
            // 1 - study 1
            BreakSession b1 = new BreakSession
            {
                id = 1,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(3).TimeOfDay,
                end_time = DateTime.Today.AddHours(3).AddMinutes(30).TimeOfDay,
            };
            breakSessions.Add(b1);

            BreakSession b2 = new BreakSession
            {
                id = 2,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(5).TimeOfDay,
                end_time = DateTime.Today.AddHours(5).AddMinutes(50).TimeOfDay,
            };
            breakSessions.Add(b2);

            StudySession s1 = new StudySession
            {
                id = 1,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(2).TimeOfDay,
                end_time = DateTime.Today.AddHours(7).TimeOfDay,
                isRecurring = false,
                currentKnowledge = 8,
                breaks = new List<BreakSession>
                    {
                        b1,
                        b2
                    }
            };
            studySessions.Add(s1);

            // 1 - study 1
            BreakSession b3 = new BreakSession
            {
                id = 3,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(9).TimeOfDay,
                end_time = DateTime.Today.AddHours(9).AddMinutes(15).TimeOfDay,
            };
            breakSessions.Add(b3);

            StudySession s2 = new StudySession
            {
                id = 3,
                date = DateTime.Today,
                start_time = DateTime.Today.AddHours(8).TimeOfDay,
                end_time = DateTime.Today.AddHours(10).TimeOfDay,
                isRecurring = false,
                currentKnowledge= 5,
                breaks = new List<BreakSession>
                    {
                        b3
                    }
            };
            studySessions.Add(s2);

            sub1.studySessions.Add(s1);
            sub1.studySessions.Add(s2);


            // Sub 2
            Subject sub2 = new Subject(2, "UI/UX");
            //2
            BreakSession b4 = new BreakSession
            {
                id = 4,
                date = DateTime.Today.AddDays(1),
                start_time = DateTime.Today.AddDays(1).AddHours(2).TimeOfDay,
                end_time = DateTime.Today.AddDays(1).AddHours(2).AddMinutes(30).TimeOfDay,
            };
            breakSessions.Add(b4);

            BreakSession b5 = new BreakSession
            {
                id = 5,
                date = DateTime.Today.AddDays(1),
                start_time = DateTime.Today.AddDays(1).AddHours(4).TimeOfDay,
                end_time = DateTime.Today.AddDays(1).AddHours(4).AddMinutes(10).TimeOfDay,
            };
            breakSessions.Add(b5);

            StudySession s3 = new StudySession
            {
                id = 3,
                date = DateTime.Today.AddDays(1),
                start_time = DateTime.Today.AddDays(1).AddHours(1).TimeOfDay,
                end_time = DateTime.Today.AddDays(1).AddHours(6).TimeOfDay,
                isRecurring = false,
                currentKnowledge = 9,
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
                date = DateTime.Today.AddDays(2),
                start_time = DateTime.Today.AddDays(2).AddHours(4).TimeOfDay,
                end_time = DateTime.Today.AddDays(2).AddHours(4).AddMinutes(30).TimeOfDay,
            };
            breakSessions.Add(b6);

            StudySession s4 = new StudySession
            {
                id = 4,
                date = DateTime.Today.AddDays(2),
                start_time = DateTime.Today.AddDays(2).AddHours(3).TimeOfDay,
                end_time = DateTime.Today.AddDays(2).AddHours(5).TimeOfDay,
                isRecurring = false,
                currentKnowledge = 10,
                breaks = new List<BreakSession>
                    {
                        b6
                    }
            };
            studySessions.Add(s4);

            sub2.studySessions.Add(s3);
            sub2.studySessions.Add(s4);


            // Sub 3
            Subject sub3 = new Subject(3, "Maths");
            // 3
            BreakSession b7 = new BreakSession
            {
                id = 7,
                date = DateTime.Today.AddDays(3),
                start_time = DateTime.Today.AddDays(3).AddHours(5).TimeOfDay,
                end_time = DateTime.Today.AddDays(3).AddHours(5).AddMinutes(40).TimeOfDay,
            };
            breakSessions.Add(b4);

            BreakSession b8 = new BreakSession
            {
                id = 5,
                date = DateTime.Today.AddDays(3),
                start_time = DateTime.Today.AddDays(3).AddHours(7).TimeOfDay,
                end_time = DateTime.Today.AddDays(3).AddHours(7).AddMinutes(15).TimeOfDay,
            };
            breakSessions.Add(b5);

            StudySession s5 = new StudySession
            {
                id = 3,
                date = DateTime.Today.AddDays(3),
                start_time = DateTime.Today.AddDays(3).AddHours(3).TimeOfDay,
                end_time = DateTime.Today.AddDays(3).AddHours(9).TimeOfDay,
                isRecurring = false,
                currentKnowledge= 4,
                breaks = new List<BreakSession>
                    {
                        b7,
                        b8
                    }
            };
            studySessions.Add(s3);

            BreakSession b9 = new BreakSession
            {
                id = 9,
                date = DateTime.Today.AddDays(4),
                start_time = DateTime.Today.AddDays(4).AddHours(3).TimeOfDay,
                end_time = DateTime.Today.AddDays(4).AddHours(3).AddMinutes(45).TimeOfDay,
            };
            breakSessions.Add(b6);

            StudySession s6 = new StudySession
            {
                id = 4,
                date = DateTime.Today.AddDays(4),
                start_time = DateTime.Today.AddDays(4).AddHours(2).TimeOfDay,
                end_time = DateTime.Today.AddDays(4).AddHours(7).TimeOfDay,
                isRecurring = false,
                currentKnowledge = 10,
                breaks = new List<BreakSession>
                    {
                        b6
                    }
            };
            studySessions.Add(s4);

            sub3.studySessions.Add(s5);
            sub3.studySessions.Add(s6);

            subjects.Add(sub1);
            subjects.Add(sub2);
            subjects.Add(sub3);
        }


    }

}


