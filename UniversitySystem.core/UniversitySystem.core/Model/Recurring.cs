using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.core.Model
{
    public class Recurring
    {
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        List<BaseSession> recurringSessions { get; set; }

        public Recurring() { }



    }
}
