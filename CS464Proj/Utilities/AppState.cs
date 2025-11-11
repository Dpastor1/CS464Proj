using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464Proj.Utilities
{
    /// <summary>
    /// Shared Object used to indicate completedness
    /// </summary>
    public class AppState
    {
        public bool SingleBoxCompletion { get; set; } = false;
        public List<Result> SingleBoxResults { get; set; }
        public bool DoubleBoxCompletion { get; set; } = false;
        public List<Result> DoubleBoxResults { get; set; }
        public bool CalendarCompletion { get; set; } = false;
        public List<Result> CalendarResults { get; set; }
        public bool SmallCalendarCompletion { get; set; } = false;
        public List<Result> SmallCalendarResults { get; set; }
    }
}
