using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    /// <summary>
    /// Represents a specification used to encapsulate query logic for an entity.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    public interface ISpecification<T>
    {
        /// <summary>
        /// Gets the filtering criteria expression.
        /// </summary>
        Expression<Func<T, bool>> Criteria { get; }

        /// <summary>
        /// Gets the navigation properties to include (strongly-typed).
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }

        /// <summary>
        /// Gets a value indicating whether the status condition should be applied.
        /// </summary>
        bool CheckStatus { get; }

        /// <summary>
        /// Gets the navigation properties to include (string-based).
        /// </summary>
        List<string> IncludeStrings { get; }

        /// <summary>
        /// Gets the include conditions used to modify the query dynamically.
        /// </summary>
        List<Func<IQueryable<T>, IQueryable<T>>> IncludeConditions { get; }

        /// <summary>
        /// Gets the expression used to order the result ascending.
        /// </summary>
        Expression<Func<T, object>> OrderBy { get; }

        /// <summary>
        /// Gets the expression used to order the result descending.
        /// </summary>
        Expression<Func<T, object>> OrderByDescending { get; }

        /// <summary>
        /// Gets the expression used to group the result.
        /// </summary>
        Expression<Func<T, object>> GroupBy { get; }

        /// <summary>
        /// Gets the raw SQL query to be executed.
        /// </summary>
        string SqlQuery { get; }

        /// <summary>
        /// Gets the number of records to take.
        /// </summary>
        int Take { get; }

        /// <summary>
        /// Gets the number of records to skip.
        /// </summary>
        int Skip { get; }

        /// <summary>
        /// Gets a value indicating whether paging is enabled.
        /// </summary>
        bool IsPagingEnabled { get; }

        /// <summary>
        /// Adds a raw SQL query to the specification.
        /// </summary>
        /// <param name="sqlQuery">The SQL query string.</param>
        void AddSqlQuery(string sqlQuery);

        /// <summary>
        /// Adds an additional filtering criteria to the specification.
        /// </summary>
        /// <param name="additionalCriteria">The additional filter expression.</param>
        void AddCriteria(Expression<Func<T, bool>> additionalCriteria);
    }
}
