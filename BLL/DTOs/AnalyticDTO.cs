using System;
using DAL.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs
{
	public class AnalyticDTO
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

