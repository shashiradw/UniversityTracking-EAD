using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core.Services
{
    public class SubjectService : ISubjectService
    {
        List<Session> ISubjectService.filterSubjectByDate(Subject subject, DateTime start_date, string filter_mode)
        {
            List<Session> filteredSessions = new List<Session>();

            foreach (Session session in subject.sessions)
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
    }
}

