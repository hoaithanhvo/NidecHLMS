using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Paging
{
    public class PagedResult<T>
    {
        public IReadOnlyList<T> Items { get; init; } = new List<T>();
        public int PageIndex { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
    }
}
