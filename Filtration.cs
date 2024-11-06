using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD08
{
    public static class Filtration
    {

        public static List<Employee> FilterPerId(List<Employee> param)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {

                if (emp.Id == 10)
                {
                    result.Add(emp);
                }
            }
            return result;

        }
        public static List<Employee> FilterPerSalary(List<Employee> param)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {

                if (emp.Salary > 3000)
                {
                    result.Add(emp);
                }
            }
            return result;

        }
        public static List<Employee> FilterPer(List<Employee> param, MyDelegate del)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in param)
            {

                if (del(emp))
                {
                    result.Add(emp);
                }
            }
            return result;

        }

    }
}
