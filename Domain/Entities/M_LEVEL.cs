using NidecSystemShared.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class M_LEVEL : BaseEntity<int>
	{
		public string LevelCode { get; set; }
		public int? Experienced { get; set; }
		public int? MaxScore { get; set; }	
		public int? MinScore { get; set; }	
		public string? Condition { get; set; }	
		public string? Action { get; set; }
        public string Type { get; set; }
		public ICollection<M_TAG> M_Tags { get; set; }
		public ICollection<T_TRAINING_RESULT> T_TrainingResults { get; set; }
		public ICollection<T_SKILLMAP_RESULT> T_SkillmapResults { get; set; }
	}
}
