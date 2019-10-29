using System;

namespace Domain
{
    public class Employee
    {
        public Department Department { get; set; } = new Department();
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
