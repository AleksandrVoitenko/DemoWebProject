using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.Application.Common.Exceptions
{
    internal class UnavailableOperationException : Exception
    {
        public UnavailableOperationException(string name, object key)
            : base($"This operation cannot be performed with entity \"{name}\" ({key})") { }
    }
}
