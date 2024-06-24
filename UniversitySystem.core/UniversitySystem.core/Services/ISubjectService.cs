using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core.Services
{
    public interface ISubjectService
    {
        List<Session> filterSubjectByDate(Subject subject, DateTime start_date, string filter_mode);

    }
}
