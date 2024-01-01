using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model.Entity
{
	public class Conversion
	{
		public int ID { get; set; }

		[ForeignKey("Campaign")]
		public int CampaignId { get; set; }
		public float ConversionRate { get; set; }

		public virtual Campaign Campaign { get; set; }
	}
}

