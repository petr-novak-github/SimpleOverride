using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//v decku ve tride mam metodu a v te metode dedim metodu z rodice a pridavam neco navic, viz trida employee, nebo trida student
// dedeni metody rodice base.writeInfo()
// takze override, prekryvani je dedeni metody rodice do decka a pak neco pridam v decku??
// a overloading, pretezovani je vice konstruktoru at muzu vytvaret instance s vice paramatery?? beztaaak



namespace SimpleOverride
{

    class Person
    {
        public int age;
        public Person() { }
        public Person(int v)
        {
            age = v;
        }
        public void writeInfo()
        {      //
            Console.Write("věk:  " + age); //
        }                            //
    }
    class Employee : Person
    {
        public int salary;
        public Employee(int v, int p)
          : base(v)
        {
            salary = p;
        }
        public void writeInfo()
        {      //
            base.writeInfo();            //pokud neuvedeme base., pak rekurzivní volání sebe sama, přeteče zásobník
            Console.Write(", salary: " + salary); //        
        }
    }

    class Student : Person
    {
        public int scholarship;
        public Student(int v, int s)
          : base(v)
        {                //
            scholarship = s;            //
        }
        public void writeInfo()
        {
            base.writeInfo();            //pokud neuvedeme base., pak rekurze
            Console.WriteLine(", scholarship: " + scholarship);//
        }
    }

    class Accountant : Employee
    {
        public Accountant(int v, int p)
          : base(v, p)
        {             //
        }
        public void writeInfo()
        {
            base.writeInfo();            //
            Console.WriteLine();       //
        }
    }

    class Teacher : Employee
    {
        public int teachingTime;
        public Teacher(int v, int p, int u)
          : base(v, p)
        {             //
            teachingTime = u;                  //
        }
        public void writeInfo()
        {
            base.writeInfo();            //
            Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(20, 1000);
            s1.writeInfo();
            Accountant e1 = new Accountant(30, 12000);
            e1.writeInfo();
            Teacher u1 = new Teacher(40, 20000, 22);
            u1.writeInfo();
        }
    }
}
