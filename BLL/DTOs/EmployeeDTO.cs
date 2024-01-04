using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs
{
	public class EmployeeDTO
	{
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }

        [Required]
        public string Role { get; set; }

    }
}

