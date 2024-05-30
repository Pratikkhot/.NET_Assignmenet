namespace Ques4
{
    
    public struct Student
    {
        private string name;
        private string gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student()
        {
            name = "";
            gender = "";
            age = 0;
            std = 0;
            div = 'A';
            marks = 0;
        }
        public Student(string name, string gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Std
        {
            get { return std; }
            set { std = value; }
        }

        public char Div
        {
            get { return div; }
            set { div = value; }
        }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public void acceptDetails()
        {
            Console.WriteLine("enter the value of name");
            Name  = Console.ReadLine();

            Console.WriteLine("enter the gender");
            Gender = Console.ReadLine();

            Console.WriteLine("enter the age");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the std");
            Std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the Div");
            Div = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter the marks");
            Marks = Convert.ToDouble(Console.ReadLine());

        }
        public void printDetails()
        {
            Console.WriteLine("Name:- " + Name + " Gender:- " + Gender + " Age:- " + Age +" Std:- " + Std + " Div:- " + Div + " Marks:- " + Marks);
        }
    }

    internal class Program
    {   
        static void Main(string[] args)
        {
            Student student = new Student();
            student.acceptDetails();
            student.printDetails();
        }
    }
}
