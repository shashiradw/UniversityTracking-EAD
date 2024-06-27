using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core.Services
{
    public class SessionController
    {
        private DataManagerDB _dataManager;

        public SessionController()
        {
            _dataManager = DataManagerDB.Instance;
        }

        public StudySession createStudySession()
        {
            int newId = generateStudySessionID();
            return new StudySession(newId);
        }

        public int generateStudySessionID()
        {
            int lastId = 1;
            List<StudySession> sortedStudySessions = _dataManager.studySessions.OrderBy(s => s.id).ToList();

            if (sortedStudySessions.Count > 0)
                lastId = sortedStudySessions.Last().id;

            return lastId + 1;
        }

        public int generateBreakSessionID()
        {
            int lastId = 1;
            List<BreakSession> sortedBreakSessions = _dataManager.breakSessions.OrderBy(s => s.id).ToList();
            if (sortedBreakSessions.Count > 0)
                lastId = sortedBreakSessions.Last().id;

            return lastId + 1;
        }

        public BreakSession createBreakSession()
        {
            // Set the id
            int newId = generateBreakSessionID();
            return new BreakSession(newId);
        }

        public bool AddBreak(StudySession studySession, BreakSession breakSession)
        {
            studySession.breaks.Add(breakSession);
            _dataManager.breakSessions.Add(breakSession);
            return true;
        }

        public bool saveStudySession(Subject subject, StudySession studySession)
        {
            // Check if id is already exists
            StudySession existingSession = _dataManager.studySessions.FirstOrDefault(s => s.id == studySession.id);

            // Handle recurrring
            if (existingSession != null)
            {
                // If the session already exists - update
                existingSession.date = studySession.date;
                existingSession.start_time = studySession.start_time;
                existingSession.end_time = studySession.end_time;
                existingSession.isRecurring = studySession.isRecurring;
                existingSession.breaks = studySession.breaks;
                existingSession.recurringSessions = studySession.recurringSessions;
            }
            else
            {
                // Handle new session
                subject.sessions.Add(studySession);
                _dataManager.studySessions.Add(studySession);
            }


            // Save recurring sessions
            if (studySession.recurringSessions.Count > 0)
            {
                foreach (StudySession rs in studySession.recurringSessions)
                {
                    StudySession es = _dataManager.studySessions.FirstOrDefault(s => s.id == rs.id);
                    if (es == null)
                    {
                        subject.sessions.Add(rs);
                        _dataManager.studySessions.Add(rs);
                    }
                }

            }

            return true;
        }

        public bool saveBreakSession(StudySession studySession, BreakSession breakSession)
        {
            // Check if id is already exists
            BreakSession existingSession = _dataManager.breakSessions.FirstOrDefault(s => s.id == breakSession.id);

            if (existingSession != null)
            {
                // If the session already exists - update
                existingSession.date = breakSession.date;
                existingSession.start_time = breakSession.start_time;
                existingSession.end_time = breakSession.end_time;
            }
            else
            {
                // Handle new session
                breakSession.isBreak = true;
                studySession.breaks.Add(breakSession);
                _dataManager.breakSessions.Add(breakSession);
            }
            return true;
        }

        public bool DropStudySession(StudySession session)
        {
            return _dataManager.studySessions.Remove(session);
        }

        public bool DropBreakSession(BreakSession session)
        {
            return _dataManager.breakSessions.Remove(session);
        } 

            public List<BreakSession> getBreakSessions()
        {
            return _dataManager.breakSessions;
        }

        public List<StudySession> getStudySessions()
        {
            return _dataManager.studySessions;
        }

        public List<StudySession> getStudySessionsBySubject(Subject subject)
        {
            //<StudySession> filteredSessions = _dataManager.studySessions.Where(s => s.id == subject.id).ToList();
            return subject.sessions;
        }

        public bool checkConflictBreakSession(StudySession studySession, TimeSpan start_time, TimeSpan end_time)
        {
            if (!(studySession.start_time <= start_time && end_time <= studySession.end_time))
            {
                return true;
            }

            foreach (BreakSession existingSession in studySession.breaks)
            {
                if (start_time < existingSession.end_time && end_time > existingSession.start_time)
                {
                    return true;
                }
            }
            return false;
        }

        public StudySession checkConflictStudySession(StudySession studySession)
        {
            // Check Study session conflict with other study sessions
            foreach (StudySession existingSession in _dataManager.studySessions)
            {
                if (studySession.id !=existingSession.id && existingSession.date.Date == studySession.date.Date && studySession.start_time < existingSession.end_time && studySession.end_time > existingSession.start_time)
                {
                    return existingSession;
                }
            }
            return null;
        }

        public BreakSession checkStudySessionConflictWithBreaks(StudySession studySession, DateTime date, TimeSpan start_time, TimeSpan end_time)
        {
            
            // Check If StudySession, Conflict with breaks in EditMode
            if (studySession.breaks.Count() > 0)
            {
                foreach (BreakSession existingSession in studySession.breaks)
                {
                    if (existingSession.date.Date == date.Date && (existingSession.start_time < start_time || existingSession.end_time > end_time))
                    {
                        return existingSession;
                    }
                }
            }

            return null;
        }

        public void moveByOneday(BaseSession session)
        {
            // Move the date by one day
            session.date = session.date.AddDays(1);
        }
      
        // Handle recurring 
        public List<StudySession> addRecurringStudy(StudySession session, DateTime start_date, DateTime end_date)
        {
            DateTime current_date = start_date.AddDays(1);

            int newId = generateStudySessionID();

            if (session.id == newId) 
            {
                newId += 1;
            }

            List<StudySession> recurSessions = new List<StudySession>();
         
            while (current_date.Date <= end_date.Date)
            {
                StudySession rsession= session.Clone();
                // Set new id
                rsession.id = newId;
                rsession.date = current_date.Date;
                rsession.isRecurring = false;
       
                // Check conflict
                StudySession conflict= checkConflictStudySession(rsession);
                
                if (conflict == null)
                {
                    recurSessions.Add(rsession);
                }
                newId += 1;
                current_date = current_date.AddDays(1);
            }

           
            return recurSessions;
        }

    }
}
