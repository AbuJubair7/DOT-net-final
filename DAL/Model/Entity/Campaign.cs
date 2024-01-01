using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model.Entity
{
	public class Campaign
	{
		
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public bool Status { get; set; }
		[Required]
		public DateTime Date { get; set; }

	}
}

