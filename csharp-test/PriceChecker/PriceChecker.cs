using System;
using System.Collections.Generic;

namespace PriceChecker
{
    public class PriceChecker
	{
		/// <summary>
		/// Application COLT reads prices in application MSD, between 2 dates and a given product id.
		/// At one date and for a product id, we have 0 to n prices and these prices can be official or not.
		/// To have an indicator on price quality and for monitoring purpose, COLT has a control that counts number of dates with more that th official prices by date.
		/// </summary>
		/// <returns>
		/// The number of dates with at least th official prices.
		/// </returns>
		/// <param name="prices">Input prices coming from MSD.</param>
		/// <param name="th">The threshold on number of prices.</param>
		public int CheckPrices(List<PriceDto> prices, int th)
        {
            //body to add
            int count = 0;
            //...

            return count;
        }
	}

	public class PriceDto
	{
		public long ProductId { get; set; }
		public DateTime Date { get; set; }
		public bool IsOfficial { get; set; }
		public double Value { get; set; }
	}
}

