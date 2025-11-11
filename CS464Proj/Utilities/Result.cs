using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464Proj.Utilities
{
    public class Result
    {
        public double TimeTaken { get; set; }
        public bool Correct { get; set; }
        public Result(double timeTaken, bool correct)
        {
            TimeTaken = timeTaken;
            Correct = correct;
        }
    }
}
