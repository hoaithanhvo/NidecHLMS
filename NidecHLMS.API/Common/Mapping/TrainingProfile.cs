using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NidecHLMS.API.DTOs.Trainings.Create;
using NidecHLMS.API.DTOs.Trainings.GetList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mapping
{
	public class TrainingProfile : Profile
	{
		public TrainingProfile()
		{
			CreateMap<CreateTrainingRequest, CreateTrainingCommand>();
			CreateMap<GetTrainingContentRequest, GetTrainingListQuery>()
				.ForMember(dest => dest.PageIndex, opt => opt.MapFrom(src => src.Paging.PageIndex))
				.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.Paging.PageSize))
				.ForMember(dest => dest.Keyword, opt => opt.MapFrom(src => src.Keyword));
			CreateMap<TrainingContentDto, TrainingContentListItemResponse>();
		}
	}
}
