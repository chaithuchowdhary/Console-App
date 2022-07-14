namespace ConsoleApp1
{
    public enum Department { IT, Sales,Production,Civil,Accounts}

    internal class Employee
    {
        //private int id;
        //private string name;
        //private double salary;
        static int count = 0;

        public string name { get; set; }
        public int id { get; set; }
        public decimal salary { get; set; }
        public Department dept { get; set; }
        public DateOfJoining doj { get; set; }
        public Employee(int id,string name,decimal salary,Department dept,DateOfJoining doj)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.dept = dept;
            count++;
            this.doj = doj;
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return string.Format("ID : {0}\nName : {1}\nDepartment : {2}\nSalary : {3}\n" +
                "Date of Joining: {4}/{5}/{6}",id,name,dept,salary,doj.day,doj.mon,doj.year);
        }

        public static int ShowCount()
        {
            return count;
        }
        public virtual void GrossSalary()
        {
            decimal gross = salary + salary * .7m;
            Console.WriteLine($"Gross Salary {gross:C0}\n");
        }
    }
}
