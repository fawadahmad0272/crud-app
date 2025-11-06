using System.ComponentModel.DataAnnotations;
namespace CrudApp.Models
{
    public class Student
    {
        [Key]
        [Display (Name ="Student ID")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }
        [Required]
        [Display(Name ="Email")]
        public string StudentEmail { get; set; }
        [Required]
        [Display(Name ="Course")]
        public string Course { get; set; }
        [Required]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Required]
        [Display(Name ="Is Active?")]
        public bool IsActive { get; set; }

    }
}