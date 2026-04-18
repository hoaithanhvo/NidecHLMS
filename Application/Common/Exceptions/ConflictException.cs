using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    public class ConflictException : Exception
    {
        /// <summary>
        /// 409 — Duplicate record or unique constraint conflict.
        /// Usage: throw new ConflictException("Course code 'TC-001' already exists.");
        /// </summary>
        public ConflictException(string message) : base(message)  
        {
            
        }
    }
}
