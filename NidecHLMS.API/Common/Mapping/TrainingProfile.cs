using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Queries.GetList;
using AutoMapper;
using NidecHLMS.API.DTOs.Trainings.Request;

namespace Application.Common.Mapping
{
	public class TrainingProfile : Profile
	{
		public TrainingProfile()
		{
			CreateMap<CreateTrainingFormRequest, CreateTrainingCommand>();
			CreateMap<GetTrainingContentFormRequest, GetTrainingListQuery>()
				.ForMember(dest => dest.PageIndex, opt => opt.MapFrom(src => src.Paging.PageIndex))
				.ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.Paging.PageSize))
				.ForMember(dest => dest.Keyword, opt => opt.MapFrom(src => src.Keyword));
		}
	}
}
