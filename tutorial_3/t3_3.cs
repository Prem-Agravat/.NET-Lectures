using System;

namespace tutorial_3
{
	class Student
	{
		// Private fields
		private int id;
		private string name;

		// Properties
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		// Default constructor
		public Student()
		{
			id = 0;
			name = "Unknown";
		}

		// Parameterized constructor
		public Student(int id, string name)
		{
			this.id = id;
			this.name = name;
		}

		public void Display()
		{
			Console.WriteLine("ID: " + id);
			Console.WriteLine("Name: " + name);
		}
	}

	class t3_3
	{
		static void Main(string[] args)
		{
            Console.WriteLine("25SOECE13042_Agravat Prem");
            Student obj1 = new Student(1, "Prem");
			obj1.Display();

			Console.ReadLine();
		}
	}
}