using Application.Common.DTOs;
using Application.DTOs.Responses.Trainings;
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
			CreateMap<M_TRAINING_CONTENT, TrainingListResponse>()
				.ForMember(dest => dest.Id,
					opt => opt.MapFrom(src => src.Id))

				.ForMember(dest => dest.ManagementNumber,
					opt => opt.MapFrom(src => src.ManagementNumber))

				.ForMember(dest => dest.TrainingContentName,
					opt => opt.MapFrom(src => src.TrainingContentName))

				.ForMember(dest => dest.UpdatedBy,
					opt => opt.MapFrom(src => src.UpdatedBy))

				.ForMember(dest => dest.CreatedBy,
					opt => opt.MapFrom(src => src.CreatedBy))

				// navigation mapping
				.ForMember(dest => dest.Operation,
					opt => opt.MapFrom(src => src.M_Operation))

				.ForMember(dest => dest.Lifecycle,
					opt => opt.MapFrom(src => src.M_TrainingContentLifecycle));

			// CHILD MAPS (BẮT BUỘC)
			CreateMap<M_OPERATION, OperationDTO>()
				.ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
				.ForMember(d => d.OperationName, o => o.MapFrom(s => s.OperationName));

			CreateMap<M_TRAINING_CONTENT_LIFECYCLE, TrainingContentLifecycleDTO>()
				.ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
				.ForMember(d => d.Name, o => o.MapFrom(s => s.Name));
		}
	}
}
