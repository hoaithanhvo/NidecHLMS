using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Paging
{
    public class PagingRequest
    {
        private const int MaxPageSize = 1000;
        private int _pageSize = 10;
        private int _pageIndex = 0;

        public int PageIndex 
        {
            get => _pageIndex;
            set => _pageIndex = Math.Max(0, value);
        }

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value <= 0
                ? 10
                : Math.Min(value, MaxPageSize);
        }
    }
}
