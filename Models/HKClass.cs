using System;
using System.ComponentModel.DataAnnotations;

namespace HK_Registration.Models
{
    public class HKClass
    {
        // EF will instruct the database to automatically generate this value
        [Key]
        public int CourseID { get; set; }

        [Required(ErrorMessage = "Please enter a Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a Number.")]
        public string Number { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Department.")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Credit.")]
        [Range(1,10, ErrorMessage = "Credit must be between 1 and 10.")]
        public int Credit { get; set; }

         [Required(ErrorMessage = "Please enter a Capacity.")]
        [Range(10,100, ErrorMessage = "Capacity must be between 10 and 100.")]
        public int Capacity { get; set; }

    }
}