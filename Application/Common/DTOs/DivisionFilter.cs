using NidecSystemShared.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
	public class DivisionFilter
	{
		/// <summary>
		/// Gets or sets the DivisionName
		/// </summary>
		public string? DivisionName { get; set; }

		/// <summary>
		/// Gets or sets the DivisionCd
		/// </summary>
		public string? DivisionCd { get; set; }

		/// <summary>
		/// Gets or sets the Paging
		/// </summary>
		public PagingRequest Paging { get; set; } = new PagingRequest();

		public bool UseScope { get; set; } = true;
	}
}
