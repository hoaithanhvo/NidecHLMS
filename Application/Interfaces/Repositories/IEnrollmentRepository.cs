using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
	public interface IEnrollmentRepository
	{
		Task<T_USER_TRAINING_ENROLLMENT> GetByIdAsync(int id);
		Task AddAsync(T_USER_TRAINING_ENROLLMENT entity);
		Task UpdateAsync(T_USER_TRAINING_ENROLLMENT entity);
	}
}
