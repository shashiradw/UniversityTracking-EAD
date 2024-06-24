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

        public Student(string name)
        {
            this.stu_id = 1;
            this.name = name;
            this.subjects = new List<Subject>();
        }

        public Student(int stu_id, string name, List<Subject> subjects)
        {
            this.stu_id = stu_id;
            this.name = name;
            this.subjects = subjects;
        }
    }
}
