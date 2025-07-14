using Demo_Mvc.Models;
using DemoMVC.Models;

namespace Demo_Mvc.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; } = Guid.NewGuid().ToString();  // hoặc thêm "required" nếu C# 11+
        public int Age { get; set; }
    }
}
