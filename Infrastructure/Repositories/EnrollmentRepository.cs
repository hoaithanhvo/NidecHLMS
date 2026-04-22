using Application.Interfaces.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
	public class EnrollmentRepository : IEnrollmentRepository
	{
		private readonly IUnitOfWork _unitOfWork;

		public EnrollmentRepository(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		private IGenericRepository<T_USER_TRAINING_ENROLLMENT, int> Repo
			=> _unitOfWork.GenericRepository<T_USER_TRAINING_ENROLLMENT, int>();

		public async Task<T_USER_TRAINING_ENROLLMENT> GetByIdAsync(int id)
		{
			return await Repo.GetByIdAsync(id);
		}

		public async Task AddAsync(T_USER_TRAINING_ENROLLMENT entity)
		{
			await Repo.CreateAsync(entity);
		}

		public async Task UpdateAsync(T_USER_TRAINING_ENROLLMENT entity)
		{
			await Repo.UpdateAsync(entity);
		}
	}
}
