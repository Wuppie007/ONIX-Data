using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnixData.Version3.Publishing;

namespace OnixData.Version3.Price
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class OnixDate
	{
		#region CONSTANTS

		public const int CONST_PRICE_DATE_ROLE_FROM = 14;
		public const int CONST_PRICE_DATE_ROLE_TO = 15;

		#endregion

		public OnixDate()
		{
		}

		private int dateTypeField;
		private string dateField;

		#region Helper Methods

		public bool IsDateTypeFrom()
		{
			return CONST_PRICE_DATE_ROLE_FROM.Equals(this.PriceDateRole);
		}

		public bool IsDateTypeTo()
        {
            return CONST_PRICE_DATE_ROLE_TO.Equals(this.PriceDateRole);
		}

		#endregion

		#region Reference Tags

		/// <remarks/>
		public int PriceDateRole
		{
			get
			{
				return this.dateTypeField;
			}
			set
			{
				this.dateTypeField = value;
			}
		}

		/// <remarks/>
		public string Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}
		#endregion
	}
}
