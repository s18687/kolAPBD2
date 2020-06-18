using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolAPBD2.Exceptions
{
    public class ExcAge : Exception
    {
        public ExcAge(string message)
            : base(message)
        {
        }
        public ExcAge(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        public ExcAge()
        {
        }
    }
}
