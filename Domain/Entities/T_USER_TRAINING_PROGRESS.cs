using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class T_USER_TRAINING_PROGRESS : BaseEntity<int>
	{
        public int Id { get; set; }
        public int ParticipantId { get; set; }
        public int TrainingContentId { get; set; }
        public int CurrentStepId { get; set; }
        public int StatusId { get; set; }
        public DateTime ActionDate { get; set; }
        public DateTime? DeleteDate { get; set; }
		public T_TRAINING_PARTICIPANT T_TrainingParticipant { get; set; }
        public M_TRAINING_CONTENT_STEP M_TrainingContentStep { get; set; }
		public M_STATUS M_Status { get;set;}	
	}
}
