using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs
{
	public class CompanyDTO
	{
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mobile { get; set; }
    }
}

