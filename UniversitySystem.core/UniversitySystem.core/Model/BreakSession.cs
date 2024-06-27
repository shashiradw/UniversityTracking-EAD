using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class BreakSession : BaseSession
    {
        private StudySession studySession;
        private List<BreakSession> recurringSessions;

        public BreakSession()
        {
            isBreak = true;
            recurringSessions= new List<BreakSession>();
        }

        public BreakSession(int Id)
        {
            id=Id;
            date=DateTime.Now;
            start_time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            end_time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            isBreak = true;
            recurringSessions = new List<BreakSession>();
        }
    }
}
