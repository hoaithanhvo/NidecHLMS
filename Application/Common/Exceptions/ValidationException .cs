using Application.Common.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    /// <summary>
    /// 400 — FluentValidation failures.
    /// Thrown automatically by ValidationBehaviour — never throw manually
    /// Carries structured field-level errors for the API response
    /// </summary>
    public class ValidationException: AppException
    {
        public IReadOnlyList<ValidationError> Errors { get; }
        public ValidationException(IList<ValidationFailure> failures) : base("One or more validation errors occured.")
        {
            Errors = failures
                .Select(f => new ValidationError(f.PropertyName, f.ErrorMessage))
                .ToList()
                .AsReadOnly();
        }
    }
}
