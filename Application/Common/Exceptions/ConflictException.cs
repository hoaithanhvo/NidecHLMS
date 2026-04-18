using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    public class ConflictException : AppException
    {
        /// <summary>
        /// 409 — Duplicate record or unique constraint conflict
        /// throw new ConflictException
        /// </summary>
        public ConflictException(string message) : base(message)  
        {
            
        }
    }
}
