using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// Initializes a new instance of BaseSpecification
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="checkStatus"></param>
        protected BaseSpecification(
            Expression<Func<T, bool>> criteria = null,
            bool checkStatus = true)
        {
            Criteria = criteria;
            CheckStatus = checkStatus;
        }

        /// <summary>
        /// Gets the Criteria
        /// </summary>
        public Expression<Func<T, bool>> Criteria { get; protected set; }

        /// <summary>
        /// Gets the Includes
        /// </summary>
        public List<Expression<Func<T, object>>> Includes { get; } = new();

        /// <summary>
        /// Gets the IncludeStrings
        /// </summary>
        public List<string> IncludeStrings { get; } = new();

        /// <summary>
        /// Gets the IncludeConditions
        /// </summary>
        public List<Func<IQueryable<T>, IQueryable<T>>> IncludeConditions { get; } = new();

        /// <summary>
        /// Gets a value indicating whether CheckStatus
        /// </summary>
        public bool CheckStatus { get; set; }

        /// <summary>
        /// Gets the OrderBy
        /// </summary>
        public Expression<Func<T, object>> OrderBy { get; private set; }

        /// <summary>
        /// Gets the OrderByDescending
        /// </summary>
        public Expression<Func<T, object>> OrderByDescending { get; private set; }

        /// <summary>
        /// Gets the GroupBy
        /// </summary>
        public Expression<Func<T, object>> GroupBy { get; private set; }

        /// <summary>
        /// Gets the Take
        /// </summary>
        public int Take { get; private set; }

        /// <summary>
        /// Gets the Skip
        /// </summary>
        public int Skip { get; private set; }

        /// <summary>
        /// Gets a value indicating whether IsPagingEnabled
        /// </summary>
        public bool IsPagingEnabled { get; private set; }

        /// <summary>
        /// Add include expression
        /// </summary>
        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        /// <summary>
        /// Add include string
        /// </summary>
        protected void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }

        /// <summary>
        /// Add include condition
        /// </summary>
        protected void AddIncludeCondition(Func<IQueryable<T>, IQueryable<T>> condition)
        {
            IncludeConditions.Add(condition);
        }

        /// <summary>
        /// Apply paging
        /// </summary>
        protected void ApplyPaging(int pageIndex, int pageSize)
        {
            Skip = (pageIndex - 1) * pageSize;
            Take = pageSize;
            IsPagingEnabled = true;
        }

        /// <summary>
        /// Apply OrderBy
        /// </summary>
        protected void ApplyOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }

        /// <summary>
        /// Apply OrderByDescending
        /// </summary>
        protected void ApplyOrderByDescending(Expression<Func<T, object>> orderByDescendingExpression)
        {
            OrderByDescending = orderByDescendingExpression;
        }

        /// <summary>
        /// Apply GroupBy
        /// </summary>
        protected void ApplyGroupBy(Expression<Func<T, object>> groupByExpression)
        {
            GroupBy = groupByExpression;
        }

        /// <summary>
        /// Add additional criteria (AND)
        /// </summary>
        public void AddCriteria(Expression<Func<T, bool>> additionalCriteria)
        {
            if (Criteria == null)
            {
                Criteria = additionalCriteria;
                return;
            }

            var invoked = Expression.Invoke(additionalCriteria, Criteria.Parameters);

            Criteria = Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(Criteria.Body, invoked),
                Criteria.Parameters);
        }

        /// <summary>
        /// Add raw SQL query (optional)
        /// </summary>
        public string SqlQuery { get; private set; }

        public void AddSqlQuery(string sqlQuery)
        {
            SqlQuery = sqlQuery;
        }
    }
}
