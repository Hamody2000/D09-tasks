namespace taskD08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Reposotry.Employees;


            var FilteredEmployees = Filtration.FilterPerId(employees);
            FilteredEmployees = Filtration.FilterPerSalary(employees);

            //MyDelegate del1 = new MyDelegate(Utility.PerDept);

            //MyDelegate del2 =  (Employee emp) =>
            //{
            //    return emp.Age > 30;
            //};

            //MyDelegate del3 = e1 => e1.Age > 30;

            //Employee e1 = new() {Id=1,Name="Sara",Age=50,Salary=1234,DeptId=30 };

            //Console.WriteLine(del2(e1));


            FilteredEmployees = Filtration.FilterPer(employees, e1 => e1.Age > 25);

            foreach (var item in FilteredEmployees) {

                Console.WriteLine(item);

            }


            Func<int> fun1 = () => 5 + 6;
            Func< int,int,  bool> fun2 = (x,y) => x > y;


            Predicate<Employee> pred = e => e.Salary > 2500;

            Action<int, int> act = (x, y) => Console.WriteLine(x + y);
        }
    }
}
