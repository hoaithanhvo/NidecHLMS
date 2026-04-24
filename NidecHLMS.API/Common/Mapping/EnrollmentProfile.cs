using Application.Features.Enrollments.Commands.RegisterEnrollment;
using AutoMapper;
using NidecHLMS.API.DTOs.Enrollments;

namespace NidecHLMS.API.Common.Mapping
{
	public class EnrollmentProfile : Profile
	{
		public EnrollmentProfile()
		{
			CreateMap<SubmitUserTrainingEnrollmentFormRequest, SubmitEnrollmentCommand>();
		}
	}
}
