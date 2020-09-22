using System;


namespace Static_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Change();//calling change method
                             //creating objects
            Student s1 = new Student(00, "ok");
            Student s2 = new Student(99, "ola");
            Student s3 = new Student(88, "ola");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();
        }
    }
}