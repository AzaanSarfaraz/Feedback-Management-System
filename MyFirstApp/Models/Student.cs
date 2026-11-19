using System.ComponentModel.DataAnnotations;

namespace MyFirstApp.Models
{
    public class Student 
    {
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentId { get; set; }
        [Required]
        public string course { get; set; }
        [Required]
        public string email { get; set; }

    }     
}
