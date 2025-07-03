using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? PersonID { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
    public class Employee : Person
{
    public string? EmployeeId { get; set; }
    public int Age { get; set; }
}
    }
}