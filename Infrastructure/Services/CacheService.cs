using Application.Interfaces.Services;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
        internal sealed class CacheService : ICacheService, IDisposable
        {
            /// <summary>
            /// Defines the _memoryCache
            /// </summary>
            private readonly IMemoryCache _memoryCache;

            /// <summary>
            /// Initializes a new instance of the <see cref="CacheService"/> class.
            /// </summary>
            /// <param name="memory">The memory<see cref="IMemoryCache"/></param>
            public CacheService(IMemoryCache memory)
            {
                _memoryCache = memory;
            }

            /// <summary>
            /// The Get
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="key">The key<see cref="string"/></param>
            /// <returns>The <see cref="T"/></returns>
            public T Get<T>(string key)
            {
                if (_memoryCache.TryGetValue(key, out var value) && value is T t)
                    return t;
                return default(T);
            }

            /// <summary>
            /// The Set
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="key">The key<see cref="string"/></param>
            /// <param name="value">The value<see cref="T"/></param>
            public void Set<T>(string key, T value)
            {
                _memoryCache.Set(key, value);
            }

            /// <summary>
            /// The Set
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="key">The key<see cref="string"/></param>
            /// <param name="value">The value<see cref="T"/></param>
            /// <param name="expiration">The expiration<see cref="TimeSpan"/></param>
            public void Set<T>(string key, T value, TimeSpan expiration)
            {
                _memoryCache.Set(key, value, expiration);
            }

            /// <summary>
            /// The Remove
            /// </summary>
            /// <param name="key">The key<see cref="string"/></param>
            /// <returns>The <see cref="bool"/></returns>
            public bool Remove(string key)
            {
                _memoryCache.Remove(key);
                return true;
            }

            /// <summary>
            /// The Clear
            /// </summary>
            public void Clear()
            {
                (_memoryCache as MemoryCache)?.Compact(1.0);
            }

            /// <summary>
            /// The Contains
            /// </summary>
            /// <param name="key">The key<see cref="string"/></param>
            /// <returns>The <see cref="bool"/></returns>
            public bool Contains(string key)
            {
                return _memoryCache.TryGetValue(key, out _);
            }

            /// <summary>
            /// The Dispose
            /// </summary>
            public void Dispose()
            {
                _memoryCache.Dispose();
            }
        }
    }
