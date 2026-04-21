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

		// ===== Derived properties =====
		public int TotalPages =>
			(int)Math.Ceiling((double)TotalCount / PageSize);

		public bool HasNext =>
			PageIndex < TotalPages - 1;

		public bool HasPrevious =>
			PageIndex > 0;

		// ===== ADD THIS: Deconstruct =====
		public void Deconstruct(
			out IReadOnlyList<T> items,
			out int totalCount,
			out int pageIndex,
			out int pageSize)
		{
			items = Items;
			totalCount = TotalCount;
			pageIndex = PageIndex;
			pageSize = PageSize;
		}
	}
}
