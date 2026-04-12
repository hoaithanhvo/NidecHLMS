using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_DIVISION : BaseEntity<int>
	{
		/// <summary>
		///Gets or sets the DivisionCd
		/// </summary>
		public string? DivisionCd { get; set; }

		/// <summary>
		///  Gets or sets the DivisionName
		/// </summary>
		public string? DivisionName { get; set; }

	}
}
