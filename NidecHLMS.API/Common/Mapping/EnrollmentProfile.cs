using Application.Features.Enrollments.Commands.ExecuteEnrollment;
using Application.Features.Enrollments.Commands.RegisterEnrollment;
using Application.Features.WorkflowAction.Queries.GetAvailable;
using AutoMapper;
using NidecHLMS.API.DTOs.Enrollments;

namespace NidecHLMS.API.Common.Mapping
{
	public class EnrollmentProfile : Profile
	{
		public EnrollmentProfile()
		{
			CreateMap<SubmitUserTrainingEnrollmentFormRequest, SubmitEnrollmentCommand>();
			CreateMap<ExecuteEnrollmentActionFormRequest, ExecuteEnrollmentActionCommand>();
			CreateMap<WorkFlowActionAvalibleFromRequest, GetAvailableActionsQuery>();
		}
	}
}
