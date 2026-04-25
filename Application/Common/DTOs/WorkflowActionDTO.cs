using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
	public class WorkflowActionDTO 
	{
		public int ActionId { get; set;}
		public string ActionCode { get; set;}	
		public string ActionName { get; set;}	
		public string Direction { get; set;}	
		public int DisplayOrder { get; set;}
	}
}
