using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class BaseSession
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        public TimeSpan start_time {  get; set; }

        public TimeSpan end_time { get; set; }

        public bool isBreak {  get; set; }


        public BaseSession() {
            
        }

        public BaseSession(int id, DateTime date, TimeSpan start_time, TimeSpan end_time, bool isBreak)
        {
            this.id = id;
            this.date = date;
            this.start_time = start_time;
            this.end_time = end_time;
            this.isBreak = isBreak;
        }

        /*public BaseSession Clone()
        {
            return new BaseSession
            {
                id = this.id,
                date = this.date,
                start_time = this.start_time,
                end_time = this.end_time,
                isRecurring = this.isRecurring,
                student = this.student,
                subject = this.subject,
                isBreak = this.isBreak
            };
        }*/

    }
}
