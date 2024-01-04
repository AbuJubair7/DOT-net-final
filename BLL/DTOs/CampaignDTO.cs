using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.DTOs
{
	public class CampaignDTO
	{
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public int TotalSent { get; set; }

        public int AnalyticId { get; set; }

        
        public DateTime Date { get; set; }
    }
}

