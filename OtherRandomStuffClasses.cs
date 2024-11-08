using System;
namespace HelloWorld
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Person Stine = new Person(36, "Stine");
            Student Ole = new Student(17, "Ole", "3.U");
            Teacher Svend = new Teacher(42, "Svend", "Math");

            Stine.Greet();
            Ole.Greet();
            Svend.Greet();
        }
    }

    public class Person
    {
        private int age;
        private string name;
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public virtual void Greet()
        {
            Console.WriteLine("Hey, I'm " + name + ". I'm " + age + " years old");
        }
    }


    public class Student : Person
    {
        private string attendedClass;
        public Student(int age, string name, string attendedClass) : base(age, name)
        {
            this.attendedClass = attendedClass;
        }

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("I'm from class " + attendedClass);
        }
    }

    public class Teacher : Person
    {
        private string subject;
        public Teacher(int age, string name, string subject) : base(age, name)
        {
            this.subject = subject;
        }

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("I teach " + subject);
        }
    }
}