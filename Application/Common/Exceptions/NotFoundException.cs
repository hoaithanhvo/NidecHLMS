using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    /// <summary>
    /// 404 — Entity not found
    /// throw new NotFoundException
    /// </summary>
    public class NotFoundException : AppException
    {
        public NotFoundException(string entityName, object key) : base ($"{entityName} with id {key} was not found") { }
    }
}
