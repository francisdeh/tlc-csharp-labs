using System;
using System.Linq;

namespace TlcCs
{
    public class Student : Person
    {
        private string _name { get; set; }
        string _preferedSubject { get; set; }
        string _school { get; set; }
        double[] _grades { get; set; }
        private CaffeineCapacity _caffeineCapacity { get; set; }

        public Student(string name, string preferedSubject, string school, double[] grades, CaffeineCapacity caffeineCapacity)
        {
            _name = name;
            _preferedSubject = preferedSubject;
            _school = school;
            _grades = grades;
            _caffeineCapacity = caffeineCapacity;
        }
        

       public override bool AttendLecture()
       {
           return true;
       }

       public override void TakeTest()
       {
           Console.WriteLine("Student is taking test");
       }

       public override void Listen()
       {
           Console.WriteLine("Student is listening to lectures");
       }

       public override double Rating()
       {
           return _grades.Average();
       }
    }
}