namespace ConsoleApp1
{
    internal class Student
    {

		private int id;
		private string firstName;
		private string lastName;
		private int marks;

		public Student(int id, string firstName, string lastName, int marks)
		{
			this.id = id;
			this.firstName = firstName;
			this.lastName = lastName;
			this.marks = marks;
		}

		/*public int id { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public int marks { get; set; }*/

		public override string ToString()
		{
			return string.Format("{0} {1} with ID {2} scored {3}",firstName,lastName,id,marks);
		}
	}
}
