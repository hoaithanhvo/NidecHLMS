using Application.Common.DTOs;
using Application.DTOs.Responses.Enrollments;
using Application.DTOs.Responses.Trainings;
using Application.Features.Enrollments.Commands.RegisterEnrollment;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
	public class EnrollmentMappingProfile : Profile
	{
		public EnrollmentMappingProfile() {
			CreateMap<SubmitEnrollmentCommand, T_USER_TRAINING_ENROLLMENT>();

			CreateMap<SubmitEnrollmentCommand, T_USER_TRAINING_PROGRESS>();

			CreateMap<T_USER_TRAINING_ENROLLMENT, RegisterEnrollmentResponse>().ForMember(x=>x.EnrollmentCode, o=>o.MapFrom(s=>s.EnrollmentCode));

			CreateMap<T_USER_TRAINING_ENROLLMENT, EnrollmentDTO>();
		}
	}
}
