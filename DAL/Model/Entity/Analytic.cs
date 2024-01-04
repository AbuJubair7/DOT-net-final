using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model.Entity
{
	public class Analytic
	{
		public int ID { get; set; }

		[Required]
		public float NewLeadRate { get; set; }
        [Required]
        public float ClosedWonRate { get; set; }
        [Required]
        public float ClosedLostRate { get; set; }
    }
}

