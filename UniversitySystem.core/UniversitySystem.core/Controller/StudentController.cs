using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core.Services
{
    public class StudentController 
    {
        private LogInHelper logInHelper;
        private DataStore _dataManager;

        public StudentController() 
        { 
            logInHelper = new LogInHelper();
            _dataManager = DataStore.Instance;
        }

        public bool LogIn(string username, string password)
        {
            User user = new User(username, password);
            return logInHelper.Authenticate(user);  
        }

        public void createStudent(string username) {
            _dataManager.SetStudentName(username);
        }

        public Student getStudent() 
        {
            return _dataManager.student;
        }

        public List<DayView> getWeeklyView(DateTime date)
        {
            DateTime startOfWeek = date.AddDays(-(int)date.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);
            List<DayView> weeklyView = new List<DayView>();

            for (DateTime day = startOfWeek; day <= endOfWeek; day = day.AddDays(1))
            {
                weeklyView.Add(getDayView(day));
            }
            return weeklyView;
        }

        // Calculate the day summery
        public DayView getDayView(DateTime date) 
        {
            List<StudySession> allStudySessions = _dataManager.GetAllStudySessions();
            

            int n_study =0;
            TimeSpan study_hours = TimeSpan.Zero;
            foreach (StudySession session in allStudySessions)
            {
                if(session.date.Date == date.Date)
                {
                    study_hours += session.end_time - session.start_time;
                    n_study++;
                }
            }

            int n_breaks = 0;
            TimeSpan break_hours = TimeSpan.Zero;
            foreach(BreakSession session in _dataManager.GetAllBreakSessions())
            {
                if (session.date.Date == date.Date)
                {
                    break_hours += session.end_time - session.start_time;
                    n_breaks++;
                }
            }

            TimeSpan total = study_hours + break_hours;
            DayView dayView = new DayView(
                    date.Date, study_hours, break_hours, n_study, n_breaks, total);

            return dayView;
        }

    }
}
