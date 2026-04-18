using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    /// <summary>
    /// 403 — Authenticated but not authorized for this action
    /// ForbiddenAccessException();
    /// </summary>
    public class ForbiddenAccessException : AppException
    {
        public ForbiddenAccessException() : base("You do not have permission to perform this action") { }
        public ForbiddenAccessException(string message) : base(message)
        {
            
        }
    }
}
