using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Specifications;
using Microsoft.EntityFrameworkCore;
using NidecSystemShared.Abstracts;

namespace Persistence.Specifications
{
    public class SpecificationEvaluator<T, TKey> where T : BaseEntity<TKey>
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            var query = inputQuery;

            // modify the IQueryable using the specification's criteria expression
            if (specification == null) return query;

            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            if (specification.CheckStatus)
            {
                //query = query.Where(x => x.Status);
            }

            // include all expression-based includes
            query = specification.Includes.Aggregate(
                query,
                (current, include) => current.Include(include));

            // Include any string-based include statements
            query = specification.IncludeStrings.Aggregate(
                query,
                (current, include) => current.Include(include));

            // Include any conditions-based include statements
            query = specification.IncludeConditions.Aggregate(
                query,
                (current, condition) => condition(current));

            // Apply ordering if expressions are set
            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }
            else
            {
                query = query.OrderByDescending(x => x.UpdatedDate);
            }
           
            //GroupBy
            if (specification.GroupBy != null)
            {
                query = query
                    .GroupBy(specification.GroupBy)
                    .SelectMany(x => x);
            }

            //Apply paging if needed
            if (specification.IsPagingEnabled)
            {
                query = query
                    .Skip(specification.Skip)
                    .Take(specification.Take);
            }

            return query;
        }
    }
}
