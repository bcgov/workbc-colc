﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace ColcDataLayerWcfService.Caching
{
    /// <summary>
    /// Used for data caching.
    /// Reference: http://stevescodingblog.co.uk/net4-caching-with-mvc/
    /// </summary>
    public class DefaultCacheProvider : ICacheProvider
    {
        private ObjectCache Cache { get { return MemoryCache.Default; } }

        public object Get(string key)
        {
            return Cache[key];
        }

        public void Set(string key, object data, int cacheTime)
        {
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);

            Cache.Add(new CacheItem(key, data), policy);
        }

        public bool IsSet(string key)
        {
            return (Cache[key] != null);
        }

        public void Invalidate(string key)
        {
            Cache.Remove(key);
        }
    }
}