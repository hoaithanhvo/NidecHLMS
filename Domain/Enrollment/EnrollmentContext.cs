using Domain.Enrollment.States;
using Domain.Entities;
using NidecSystemShared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment
{
	public class EnrollmentContext
	{
		private readonly T_USER_TRAINING_ENROLLMENT _entity;
		private IEnrollmentState _state;

		public EnrollmentContext(T_USER_TRAINING_ENROLLMENT entity,IEnrollmentState state)
		{
			_entity = entity;
			_state = state;
		}

		public void SetState(IEnrollmentState state,int statusId)
		{
			_state = state;
			_entity.StatusId = statusId; // 🔥 update DB field
		}
		public string GetStateName()
		{
			return _state.GetType().Name.Replace("State", "");
		}
		public Task ApproveAsync() => _state.ApproveAsync(this);
		public Task RejectAsync() => _state.RejectAsync(this);
		public Task EnrollAsync() => _state.EnrollAsync(this);
		public Task StartAsync() => _state.StartAsync(this);
		public Task CompleteAsync() => _state.CompleteAsync(this);
		public Task CancelAsync() => _state.CancelAsync(this);
		public T_USER_TRAINING_ENROLLMENT GetEntity() => _entity;
	}
}
