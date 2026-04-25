using Application.Common.DTOs;
using Application.DTOs.Responses.Enrollments;
using Application.Features.Enrollments.Commands.SubmitEnrollment;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Enrollments.Commands.RegisterEnrollment
{
	public class SubmitEnrollmentHandler
	: IRequestHandler<SubmitEnrollmentCommand, RegisterEnrollmentResponse>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IWorkflowService _workflow;
		private readonly IMapper _mapper;

		public SubmitEnrollmentHandler(IUnitOfWork unitOfWork, IMapper mapper, IWorkflowService workflow)
		{
			_unitOfWork = unitOfWork;
			_workflow = workflow;
			_mapper = mapper;

		}

		public async Task<RegisterEnrollmentResponse> Handle(SubmitEnrollmentCommand request, CancellationToken ct)
		{
			var repo = _unitOfWork
			   .GenericRepository<T_USER_TRAINING_ENROLLMENT, int>();


			// =====================================================
			// 1. MAP REQUEST → ENTITY
			// =====================================================
			var entity = _mapper.Map<T_USER_TRAINING_ENROLLMENT>(request);


			// check duplicate
			var exists = await repo.ContainsAsync(
				new SubmitEnrollmentSpec(entity.EnrollmentCode), ct);

			if(exists)
				throw new Exception("EnrollmentCode already exists");

			// =====================================================
			// 2. INIT WORKFLOW (🔥 QUAN TRỌNG)
			// =====================================================
			await _workflow.InitializeAsync(entity, ct);

			// =====================================================
			// 3. SAVE (TransactionBehavior sẽ commit)
			// =====================================================
			await repo.CreateAsync(entity, ct);

			// =====================================================
			// 4. RESPONSE
			// =====================================================
			return _mapper.Map<RegisterEnrollmentResponse>(entity);
		}
	}
}
