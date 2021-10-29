using System;

namespace Contract
{
    public class MockEmployeeDataService : IEmployeeDataService
    {
        public Employee[] GetEmployees()
        {
            return new Employee[]{
                new Employee {UserId = 12, EmployeeId = 3123, Name = "Bob Baumeister"},
                new Employee {UserId = 21, EmployeeId = 4441, Name = "Franz Ferdinant"},
                new Employee {UserId = 331, EmployeeId = 1251, Name = "Angela Merkel"}
            };
        }
    }
}