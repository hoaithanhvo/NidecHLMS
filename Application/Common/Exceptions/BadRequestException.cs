using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    /// <summary>
    /// 400 — Business rule violation that is not a field validation error
    /// throw new BadRequestException
    /// </summary>
    public class BadRequestException : AppException
    {
        public BadRequestException(string message) : base(message) { }
    }
}
