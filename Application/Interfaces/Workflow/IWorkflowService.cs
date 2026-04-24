using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
	public interface IWorkflowService
	{
		/// <summary>
		/// Khởi tạo workflow (Submit)
		/// </summary>
		Task InitializeAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			CancellationToken ct);

		/// <summary>
		/// Thực thi action → chuyển step
		/// </summary>
		Task ExecuteAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			string actionCode,
			CancellationToken ct);

		/// <summary>
		/// Lấy danh sách action có thể thực hiện tại step hiện tại
		/// </summary>
		Task<List<string>> GetAvailableActionsAsync(
			T_USER_TRAINING_ENROLLMENT entity,
			CancellationToken ct);
	}
}
