using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model.Entity
{
	public class Conversion
	{
		public int ID { get; set; }

		[Required]
		[ForeignKey("Campaign")]
		public int CampaignId { get; set; }
		[Required]
		public float ConversionRate { get; set; }

		public virtual Campaign Campaign { get; set; }
	}
}

