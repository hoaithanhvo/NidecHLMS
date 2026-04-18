using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    /// <summary>
    /// 404 — Entity not found.
    /// Usage: throw new NotFoundException(nameof(T_TRAINING_COURSE), id);
    /// </summary>
    public class NotFoundException : AppException
    {
        public NotFoundException(string entityName, object key) : base ($"{entityName} with id {key} was not found") { }
    }
}
