using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColcDataLayerWcfService.Caching
{
    /// <summary>
    /// Used for data caching.
    /// Reference: http://stevescodingblog.co.uk/net4-caching-with-mvc/
    /// </summary>
    public interface ICacheProvider
    {
        object Get(string key);
        void Set(string key, object data, int cacheTime);
        bool IsSet(string key);
        void Invalidate(string key);
    }
}
