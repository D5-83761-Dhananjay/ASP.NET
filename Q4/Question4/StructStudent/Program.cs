using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructStudent
{
    public struct Student
    {
        string name;
        bool gender;
        int age;
        int std;
        char div;
        double marks;

        public Student(string Name, bool gender, int age, int std, char div, double marks)
        {
            this.name = Name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string getName() { return name; }
        public bool getGender() { return gender; }
        public int getAge() { return age; }
        public int getStd() { return std; }
        public char getDiv() { return div; }
        public double getMarks() { return marks; }

        public void setName(string Name) { this.name = Name; }
        public void setGender(bool Gender) { this.gender = Gender; }
        public void setAge(int Age) { this.age = Age; }
        public void setStd(int Std) { this.std = Std; }
        public void setDiv(char Div) { this.div = Div; }
        public void setMarks(int Marks) { this.marks = Marks; }

        public void AcceptDetails()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender 1:Male 2:Female ");
            gender = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter std: ");
            std = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Div: ");
            div = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Gender: " + getGender());
            Console.WriteLine("age: " + getAge());
            Console.WriteLine("std: " + getStd());
            Console.WriteLine("div: " + getDiv());
            Console.Write("Marks: " + getMarks());
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.DisplayDetails();
        }
    }
}
