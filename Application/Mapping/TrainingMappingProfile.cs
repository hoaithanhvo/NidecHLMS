using Application.Common.DTOs;
using Application.DTOs.Responses.Trainings;
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
			CreateMap<M_TRAINING_CONTENT, TrainingListResponse>()
				.ForMember(dest => dest.Operation,
					opt => opt.MapFrom(src => src.M_Operation))
				.ForMember(dest => dest.Lifecycle,
					opt => opt.MapFrom(src => src.M_TrainingContentLifecycle))
				.ForMember(dest => dest.Status,
					opt => opt.MapFrom(src => src.M_Status));

			CreateMap<M_OPERATION, OperationDTO>();

			CreateMap<M_STATUS, StatusDTO>();

			CreateMap<M_TRAINING_CONTENT_LIFECYCLE, TrainingContentLifeCycleDTO>();
		}
	}
}
