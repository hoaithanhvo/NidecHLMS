using Application.Common.DTOs;
using Application.DTOs.Responses.Trainings;
using Application.Features.Trainings.Queries.GetById.DTOs;
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

			CreateMap<M_TRAINING_CONTENT, TrainingContentByIdDTO>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.ManagementNumber, opt => opt.MapFrom(src => src.ManagementNumber))
				.ForMember(dest => dest.TrainingContentName, opt => opt.MapFrom(src => src.TrainingContentName))
				.ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy))
				.ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
				.ForMember(dest => dest.Operation, opt => opt.MapFrom(src => src.M_Operation))
				.ForMember(dest => dest.TrainingContentLifeCycle, opt => opt.MapFrom(src => src.M_TrainingContentLifecycle));

			// CHILD MAPS (BẮT BUỘC)
			CreateMap<M_OPERATION, OperationDTO>()
				.ForMember(d => d.OperationCode, o => o.MapFrom(s => s.OperationCode))
				.ForMember(d => d.OperationName, o => o.MapFrom(s => s.OperationName));

			CreateMap<M_TRAINING_CONTENT_LIFECYCLE, TrainingContentLifeCycleDTO>()
				.ForMember(d => d.Code, o => o.MapFrom(s => s.Code))
				.ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
				.ForMember(d => d.RetrainingFrequency, o => o.MapFrom(s => s.RetrainingFrequency))
				.ForMember(d => d.FrequencyUnit, o => o.MapFrom(s => s.FrequencyUnit))
				.ForMember(d => d.OrderNo, o => o.MapFrom(s => s.OrderNo))
				.ForMember(d => d.IsRenew, o => o.MapFrom(s => s.IsRenew))
				.ForMember(d => d.Description, o => o.MapFrom(s => s.Description));
		}
	}
}
