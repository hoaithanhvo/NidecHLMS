using Application.Common.DTOs;
using Application.DTOs.Responses.Enrollments;
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
	

	public class StatusMappingProfile : Profile
	{
		public StatusMappingProfile()
		{
			CreateMap<M_STATUS, StatusDTO>();
		}
	}
}
