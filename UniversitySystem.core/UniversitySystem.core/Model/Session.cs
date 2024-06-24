using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class Session: BaseActivity
    {
        public List<Break> breaks { get; set; }

        public Session() {

        }

        public Session(int Id, DateTime Date, DateTime Start_time, DateTime End_time, bool IsRecurring, List<Break> Breaks)
        {
            this.breaks = Breaks;
            this.id = Id;
            this.date = Date;
            this.start_time = Start_time;
            this.end_time = End_time;
            this.isRecurring = IsRecurring;
        }

        public override string ToString()
        {
            return "Session id: " + id + " date: "+ date.Date.ToString() + " start_time" + start_time.ToString()
                + " end_time: " + end_time.ToString() + " is rucurring: " + isRecurring.ToString();
        }

    }
}
