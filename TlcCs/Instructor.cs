using System.Linq;

namespace TlcCs
{
    public class Instructor : Person
    {
        
        private string _name { get; set; }
        string _preferedSubject { get; set; }
        string _school { get; set; }
        double[] _grades { get; set; }
        private CaffeineCapacity _caffeineCapacity { get; set; }

        public Instructor(string name, string preferedSubject, string school, double[] grades, CaffeineCapacity caffeineCapacity)
        {
            _name = name;
            _preferedSubject = preferedSubject;
            _school = school;
            _grades = grades;
            _caffeineCapacity = caffeineCapacity;
        }

        public override bool AttendLecture()
        {
            throw new System.NotImplementedException();
        }

        public override void TakeTest()
        {
            throw new System.NotImplementedException();
        }

        public override void Listen()
        {
            throw new System.NotImplementedException();
        }

        public override double Rating()
        {
            return _grades.Average() * 100;
        }
    }
}