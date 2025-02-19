using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcDataLayerWcfService.CustomExceptions
{
    /// <summary>
    /// This is a custom exception for any calculator data inputs that are invalid.
    /// </summary>
    public class CalculatorDataInputException: Exception
    {
    
        public CalculatorDataInputException()
        {
        }

        public CalculatorDataInputException(string message)
            : base(message)
        {
        }

        public CalculatorDataInputException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}