using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class EmployeeService
    {
        public static void EmployeeRegistration(Employee employee)
        {
            StaticData.Employees.Add(employee);
            EmailService.SendEmail(employee.Email, "Registration", "You have been registered.");
        }
    }
}
