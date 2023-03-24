using System;
namespace SchoolDays
{
    public class Student
    {//Encapsulation
        public string ID; //attribute 
        public string Name;
        public int Age;
        public string Address;
        public int Phone;

        public virtual void DataOffical() //Polymorphism Overriding
        {
            Console.WriteLine("============");//menampilkan output
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("Phone : " + Phone);
        }
        }
    public class Teacher : Student //Inheritance
    {
        public string TeachExp; //teaching experience
        public string LastEdu; //LastEducational

        public override void DataOffical() //Polymorphism Overriding, Derived atau Child Class
        {
            base.DataOffical(); //untuk memunculkan data yang terdapat diparent
            Console.WriteLine("Teaching Experience : " + TeachExp);
            Console.WriteLine("Last Educational : " + LastEdu);
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
        Student student1 = new Student(); //object students
            student1.ID = "340013";
            student1.Name = "Kung Lao";
            student1.Age = 20;
            student1.Address = "9870 Chinatown";
            student1.Phone = 22312;

            student1.DataOffical();

        Teacher teacher1 = new Teacher(); //object teacher
            teacher1.TeachExp = "11 Years";
            teacher1.LastEdu = "Associate Degree";
            teacher1.ID = "922135";
            teacher1.Name = "Raiden";
            teacher1.Age = 43;
            teacher1.Address = "1445 Chinatown";
            teacher1.Phone = 33821;
            teacher1.DataOffical();
        }
    }
    }

