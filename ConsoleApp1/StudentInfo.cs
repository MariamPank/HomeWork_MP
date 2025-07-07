using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentInfo
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private double _score;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 18 and 50.");
                }
                _age = value;
            }
        }
        public double Score
        {
            get { return _score; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Score must be between 0 and 100.");
                }
                _score = value;
            }
        }
        public StudentInfo(string firstName, string lastName, int age, double score)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Score = score;
        }
    }
}
