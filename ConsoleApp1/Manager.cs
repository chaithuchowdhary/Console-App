using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Manager:Employee
    {
        public int Salesqty { get; set; }
        public decimal Commission { get; set; }

        public Manager() : base()
        {
            Salesqty = 0;
            Commission = 0;
        }
 
        public Manager(decimal commission, int salesqty, int id, string name, decimal salary, Department dept, DateOfJoining doj) : base(id, name, salary , dept, doj)
        {
            this.Commission = commission;
            this.Salesqty = salesqty;
        }

        public override void GrossSalary()
        {
            decimal gross = salary + salary * Salesqty * .7m;
            Console.WriteLine($"Gross Salary for Manager is {gross:C0}");
        }
    }
}
