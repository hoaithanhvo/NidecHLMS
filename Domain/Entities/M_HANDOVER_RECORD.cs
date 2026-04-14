using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitises
{

	//Ho so ban giao
	public class M_HANDOVER_RECORD : BaseEntity<int>
	{
		public string? HandoverRecordCode { get; set; }	
		public string? HandOverRepordName { get; set; }
	}
}
