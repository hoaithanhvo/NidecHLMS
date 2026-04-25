using Application.Common.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
	public class TransitionMappingProfile : Profile
	{
		public TransitionMappingProfile() {
			CreateMap<M_TRAINING_CONTENT_STEP_TRANSITION, TrainingContentStepTransitionDTO>();
		}
	}
}
