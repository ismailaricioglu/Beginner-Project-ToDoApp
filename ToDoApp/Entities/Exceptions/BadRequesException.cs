using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public abstract class BadRequesException : Exception
    {
        protected BadRequesException(string message):
            base(message)
        {

        }
    }
}
