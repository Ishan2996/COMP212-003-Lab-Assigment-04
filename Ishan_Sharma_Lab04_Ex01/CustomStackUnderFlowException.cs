using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Lab04_Ex01
{
    class CustomStackUnderFlowException : Exception
    {
        public CustomStackUnderFlowException(string message) : base(message)
        {
        }
    }
}
