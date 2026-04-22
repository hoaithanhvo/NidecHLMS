using Domain.Enrollment.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollment.Factories
{
	public interface IEnrollmentStateFactory
	{
		IEnrollmentState Create(int statusId);
	}
}
