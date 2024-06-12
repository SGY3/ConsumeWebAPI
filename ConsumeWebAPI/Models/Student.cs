using System.ComponentModel.DataAnnotations;

namespace ConsumeWebAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? StudentName { get; set; }
        [Required]
        public string? StudentGender { get; set; }
        [Required]
        public int? Age { get; set; }
    }
}
