using Application.Common.DTOs;
using Application.DTOs.Responses.Trainings;
using Application.Features.Trainings.Commands.Create;
using Application.Features.Trainings.Commands.Update;
using Application.Features.Trainings.Queries.GetAll;
using Application.Features.Trainings.Queries.GetList;
using AutoMapper;
using NidecHLMS.API.DTOs.Trainings.Request;

namespace NidecHLMS.API.Common.Mapping
{
    public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<CreateTrainingFormRequest, CreateTrainingCommand>();
            CreateMap<UpdateTrainingFormRequest, UpdateTrainingCommand>();

            CreateMap<GetTrainingContentFormRequest, GetTrainingListQuery>()
                .ForMember(dest => dest.PageIndex, opt => opt.MapFrom(src => src.Paging.PageIndex))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.Paging.PageSize));

            CreateMap<GetAllTrainingContentFormRequest, GetAllTrainingQuery>()
                .ForMember(dest => dest.PageIndex, opt => opt.MapFrom(src => src.Paging.PageIndex))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.Paging.PageSize));
        }
    }
}
