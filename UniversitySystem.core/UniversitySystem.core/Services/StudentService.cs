using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core.Services
{
    public class StudentService : IStudentService
    {
        private LogInHelper logInHelper = new LogInHelper();

        bool IStudentService.LogIn(User user)
        {
            return logInHelper.Authenticate(user);  
        }

        bool IStudentService.recordSession(Session session)
        {
            throw new NotImplementedException();
        }




    }
}
