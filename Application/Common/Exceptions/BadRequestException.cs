using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    /// <summary>
    /// 400 — Business rule violation that isn't a field validation error.
    /// Usage: throw new BadRequestException("Cannot delete a course with active attendees.");
    /// </summary>
    public class BadRequestException : AppException
    {
        public BadRequestException(string message) : base(message) { }
    }
}
