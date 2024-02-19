namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HireDate hire1 = new HireDate(10,5,2009);
            HireDate hire2 = new HireDate(10, 2, 2023);
            HireDate hire3 = new HireDate(15, 3, 2016);
            Employee[] employee = new Employee[]
            {
                new Employee(1,"Ahmed",20000, Employee.ESecurityLevel.guest, hire1,Employee.EGender.Male),
                new Employee(2,"Marina",20000, Employee.ESecurityLevel.DBA, hire2,Employee.EGender.Female),
                new Employee(3,"Omar",20000, Employee.ESecurityLevel.secretary, hire3,Employee.EGender.Male)
            };

            Array.Sort(employee, (emp1, emp2) => emp1.HireDate.Compare(emp1.HireDate, emp2.HireDate));

            // Printing the sorted array
            Console.WriteLine("Sorted Employees Based on Hire Date:");
            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }


        }
    }
}
