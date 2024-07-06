using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class StudySession: BaseSession
    {
        public List<BreakSession> breaks { get; set; }
        public List<StudySession> recurringSessions { get; set; }
        public bool isRecurring { get; set; }

        public double currentKnowledge { get; set; }

        public StudySession() {
            breaks = new List<BreakSession>();
            recurringSessions = new List<StudySession>();
        }

        public StudySession(int Id)
        {
            id = Id;
            breaks = new List<BreakSession>();
            date = DateTime.Now;
            start_time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            end_time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            isRecurring = false;
            currentKnowledge = 0;
            recurringSessions = new List<StudySession>();
        }

        public StudySession(int Id, DateTime Date, TimeSpan Start_time, TimeSpan End_time, bool IsRecurring, List<BreakSession> Breaks, double currentKnowledge)
        {
            this.breaks = Breaks;
            this.id = Id;
            this.date = Date;
            this.start_time = Start_time;
            this.end_time = End_time;
            this.isRecurring = IsRecurring;
            recurringSessions = new List<StudySession>();
            this.currentKnowledge = currentKnowledge;
        }

        public StudySession Clone()
        {
            return new StudySession
            {
                id = this.id,
                date = this.date,
                start_time = this.start_time,
                end_time = this.end_time,
                isRecurring = this.isRecurring,
                isBreak = false,
                breaks = new List<BreakSession>(),
                recurringSessions = new List<StudySession>(),
                currentKnowledge= this.currentKnowledge
            };
        }

        public override string ToString()
        {
            return "Session id: " + id + " date: "+ date.Date.ToString() + " start_time" + start_time.ToString()
                + " end_time: " + end_time.ToString() + " is rucurring: " + isRecurring.ToString();
        }

    }
}
