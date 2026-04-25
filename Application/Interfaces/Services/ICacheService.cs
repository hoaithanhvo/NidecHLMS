using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface ICacheService
    {
        /// <summary>
		/// Get Cache. If no cache -> return default
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="key">The key<see cref="string"/></param>
		/// <returns>The <see cref="T"/></returns>
		T Get<T>(string key);

        /// <summary>
        /// Set cache, cache is no expired
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key<see cref="string"/></param>
        /// <param name="value">The value<see cref="T"/></param>
        void Set<T>(string key, T value);

        /// <summary>
        /// Set cache, cache is expired
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key<see cref="string"/></param>
        /// <param name="value">The value<see cref="T"/></param>
        /// <param name="expiration">The expiration<see cref="TimeSpan"/></param>
        void Set<T>(string key, T value, TimeSpan expiration);

        /// <summary>
        /// Remove cache by key
        /// </summary>
        /// <param name="key">The key<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        bool Remove(string key);

        /// <summary>
        /// Clear cache
        /// </summary>
        void Clear();

        /// <summary>
        /// Check key is exist in cache
        /// </summary>
        /// <param name="key">The key<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        bool Contains(string key);
    }
}
