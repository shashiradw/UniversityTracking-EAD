using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class BaseActivity
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        public DateTime start_time {  get; set; }

        public DateTime end_time { get; set; }

        public bool isRecurring { get; set; }

        public BaseActivity() { }

        public BaseActivity(int id, DateTime date, DateTime start_time, DateTime end_time, bool isRecurring)
        {
            this.id = id;
            this.date = date;
            this.start_time = start_time;
            this.end_time = end_time;
            this.isRecurring = isRecurring;
        }


    }
}
