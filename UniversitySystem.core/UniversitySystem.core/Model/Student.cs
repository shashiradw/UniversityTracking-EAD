using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class Student
    {
        public int stu_id {  get; set; }
        public string name { get; set; }
        public List<Subject> subjects { get; set; }

        public Student()
        {
            stu_id = 1;
            name = string.Empty;
            subjects = new List<Subject>();
        }
    }
}
