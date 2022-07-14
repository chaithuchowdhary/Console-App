using System;
namespace ConsoleApp1
{
    
    
    class Program
    {
        static void Main()
        {
            Circle a = new(10);
            a.area();

            Cylinder c = new(5, 10);
            c.area();

        }
    }
}



/*static void Main()
{
    //Student s = new(1, "billy", "joel", 98);
    //Console.WriteLine(s.ToString());
    Employee[] array = new Employee[5];
    array[0] = new(101, "Mark henry", 60000, Department.IT, new DateOfJoining(3, 04, 2021));
    array[1] = new(102, "James Smith", 55000, Department.Sales, new DateOfJoining(2, 07, 2021));
    array[2] = new(103, "Robert Smith", 50000, Department.Production, new DateOfJoining(4, 09, 2021));
    array[3] = new(104, "Maria Hernande", 50000, Department.Accounts, new DateOfJoining(12, 10, 2021));
    array[4] = new(105, "Billy Joel", 65000, Department.IT, new DateOfJoining(03, 03, 2021));
    foreach (Employee n in array)
    {
        Console.WriteLine(n);
        n.GrossSalary();
    }

    Console.WriteLine($"total count of employees are {Employee.ShowCount()}");
    Console.WriteLine();
    Manager m1 = new(2000m, 12, 201, "Jake Lollyd", 350000, Department.IT, new DateOfJoining(20, 07, 2021));
    Console.WriteLine(m1);
    m1.GrossSalary();

}*/