using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExceptionPropia : Exception
    {
        public ExceptionPropia(string message) : base(message)
        {

        }

        public override string Message => $"Maxi Lenzuen: {base.Message}";
    }
}
