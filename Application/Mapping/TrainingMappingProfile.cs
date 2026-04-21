using Application.Features.Trainings.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
	public class TrainingMappingProfile : Profile
	{
		public TrainingMappingProfile()
		{
			CreateMap<M_TRAINING_CONTENT, TrainingContentDto>();
		}
	}
}
