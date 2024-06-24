using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core.Services
{
    public interface IStudentService
    {
        bool recordSession(Session session);

        bool LogIn(User user);
    }
}
