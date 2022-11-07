using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility;

internal class StaticData
{
    public static List<Employee> Employees { get; set; } = new List<Employee>();
}
