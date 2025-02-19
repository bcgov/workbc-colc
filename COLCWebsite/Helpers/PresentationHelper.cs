using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COLC.COLCWebsite.Helpers
{
    public static class PresentationHelper
    {
        /// <summary>
        /// Rounding off to nearest 10, 100, 1000 and other multiples of 10
        /// Reference: http://codingsense.wordpress.com/2010/02/04/rounding-off-to-nearest-in-c/
        /// </summary>
        /// <param name="amount">amount to be rounded</param>
        /// <param name="roundTo">rounding off to the near multiple of 10 (e.g. 100)</param>
        /// <returns></returns>
        public static double RoundToNearest(double amount, double roundTo)
        {
            double excessAmount = amount % roundTo;
            if (excessAmount < (roundTo / 2))
            {
                amount -= excessAmount;
            }
            else
            {
                amount += (roundTo - excessAmount);
            }

            amount = Math.Round(amount / roundTo) * roundTo;

            return amount;
        } 
       
        /// <summary>
        /// Converts yearly amount into monthly
        /// </summary>
        /// <param name="amount">yearly amount</param>
        /// <returns>monthly amount</returns>
        public static decimal ConvertToMonthly(decimal amount)
        {
            decimal monthlyAmount = 0;
            monthlyAmount = Math.Round((amount / 12), 2, MidpointRounding.AwayFromZero);

            return monthlyAmount;
        }


        // <summary>
        /// Rounds yearly amount to the nearest whole number.
        /// </summary>
        /// <param name="amount">yearly amount</param>
        /// <returns>monthly amount</returns>
        public static decimal RoundYearlyAmount(decimal amount)
        {
            decimal yearlyAmount = 0;
            yearlyAmount = Math.Round(amount, 0, MidpointRounding.AwayFromZero);

            return yearlyAmount;

        }

        /// <summary>
        /// Converts amount to string for presentation on the the front-end
        /// </summary>
        /// <param name="amount">value to be converted</param>
        /// <returns>converted value in #,##0 format</returns>
        public static string ConvertAmountToString(decimal amount)
        {
            return String.Format("{0:#,##0}", amount);
        }

    }
}
