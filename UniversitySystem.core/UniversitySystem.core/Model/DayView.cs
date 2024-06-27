using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class DayView
    {
        public DateTime Date { get; set; }
        public TimeSpan study_hours { get; set; }
        public TimeSpan break_hours { get; set; }
        public int n_study_sessions { get; set; }
        public int n_break_sessions { get; set; }
        public TimeSpan total_hours { get; set; }

        public DayView() { }

        public DayView(DateTime date, TimeSpan study_hours, TimeSpan break_hours, int n_study_sessions, int n_break_sessions, TimeSpan total_hours)
        {
            Date = date;
            this.study_hours = study_hours;
            this.break_hours = break_hours;
            this.n_study_sessions = n_study_sessions;
            this.n_break_sessions = n_break_sessions;
            this.total_hours = total_hours;
        }   
    }
}
