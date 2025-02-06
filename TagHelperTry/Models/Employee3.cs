using System.ComponentModel.DataAnnotations;

namespace TagHelperTry.Models
{
    public class Employee3
    {
        [Key]
        [Required(ErrorMessage ="Please enter ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please Select Department" )]
        public int Department { get; set; }
        [Required(ErrorMessage = "Select Gender")]
        public string  Gender { get; set; }
        [Required(ErrorMessage = "Enter Address")]
        public string Address { get; set; }
    }
    public class Departments
    {
        public int deptid { get; set; }
        public string name { get; set; }
    }
}
