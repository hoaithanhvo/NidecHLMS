using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    /// <summary>
    /// 401 — Unauthenticated 
    /// throw new UnauthorizedException();
    /// </summary>
    public class UnauthorizedException : AppException
    {
        public UnauthorizedException() : base("Authentication is required to access this resource.") { }
        
        public UnauthorizedException(string message) : base(message)
        {
        }
    }
}
