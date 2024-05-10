using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Employee")]
    public class Employee {
    [Key]
        public string? EmployeeId {get; set;}
        public string? FullName {get; set;}
        public string? Address {get; set;}
        public int? Age {get; set;}
    }
}