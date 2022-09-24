/*
Key points:
1.  A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.
2.  Delegates are especially used for implementing events and the call-back methods.
3.  Declaration,initialization and use of delegate are the following:
*/


namespace CsharpPlay.Akhtar.Concepts
{
    public delegate bool IsPromotable(Employee employee);
    public class Employee
    {
        public string? Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employee, IsPromotable IsEligableToPromote)
        {
            foreach (Employee emp in employee)
            {
                if (IsEligableToPromote(emp))
                {
                    Console.WriteLine($"{emp.Name} has promoted with experience {emp.Experience}");
                }
            }
        }
    }




    public partial class DelegateUsage
    {
        [Fact]
        public void DelegateTest()
        {
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { Name = "Down", Salary = 1200, Experience = 6 });
            listEmployee.Add(new Employee() { Name = "John", Salary = 2200, Experience = 3 });
            listEmployee.Add(new Employee() { Name = "Smith", Salary = 3200, Experience = 4 });
            listEmployee.Add(new Employee() { Name = "Handy", Salary = 4200, Experience = 5 });

            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(listEmployee, isPromotable);
            // Assert.True(isPromotable);

        }
        public static bool Promote(Employee employee)
        {
            return employee.Experience >= 5 ? true : false;

        }
    }

}