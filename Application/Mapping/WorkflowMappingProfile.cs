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
	public class WorkflowMappingProfile : Profile
	{
		public WorkflowMappingProfile()
		{
			CreateMap<M_TRAINING_CONTENT_STEP_TRANSITION, WorkflowActionDTO>()
				.ForMember(dest => dest.ActionId, opt => opt.MapFrom(src => src.M_WorkflowAction.Id))
			 .ForMember(dest => dest.ActionCode, opt => opt.MapFrom(src => src.M_WorkflowAction.ActionCode))
			.ForMember(dest => dest.ActionName, opt => opt.MapFrom(src => src.M_WorkflowAction.ActionName))
			.ForMember(dest => dest.Direction, opt => opt.MapFrom(src => src.M_WorkflowAction.Direction));
		}
	}
}
