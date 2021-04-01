using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRestApi.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name Cannot be of more than 50 characters")]

        public string Name { get; set; }
        public string LastName { get; set; }
        public int RollNo { get; set; }

    }
}
