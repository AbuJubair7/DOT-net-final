using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs
{
	public class ReportDTO
	{
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string CreatedBy { get; set; }
    }
}

