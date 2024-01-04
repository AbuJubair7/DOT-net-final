using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model.Entity
{
	public class Company
	{
		public int Id { get; set; }
		[Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mobile { get; set; }

     
		public virtual ICollection<Employee> Employees { get; set; }
        public Company()
        {
            Employees = new List<Employee>();
        }
    }
}

