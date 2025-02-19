using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcDataLayerWcfService.CustomExceptions
{
    /// <summary>
    /// This is a custom exception for Kentico CMS database errors.
    /// </summary>
    public class KenticoCMSDatabaseException : Exception
    {
        public KenticoCMSDatabaseException()
        {
        }

        public KenticoCMSDatabaseException(string message)
            : base(message)
        {
        }

        public KenticoCMSDatabaseException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}