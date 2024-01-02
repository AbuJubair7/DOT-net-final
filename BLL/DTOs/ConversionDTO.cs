using System;
using DAL.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs
{
	public class ConversionDTO
	{
        public int ID { get; set; }

        [Required]
        public int CampaignId { get; set; }
        [Required]
        public float ConversionRate { get; set; }

    }
}

