using Domain.Entities;
using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public  class M_TRAINING_CONTENT_TYPE : BaseEntity<int>
	{
		public string ContentTypeNameVI { get; set; }
		public string ContentTypeNameEN { get; set; }
	}
}
