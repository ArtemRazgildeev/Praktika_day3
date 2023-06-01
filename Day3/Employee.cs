using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Employee
    {
        private string _fio;

        private double _salary;

        private int _otdel;

        private int _id = 0;

        static int count;
        public int Id()
        {
            _id++;
            count = _id;
            return count;
        }
        public int Id0()
        {
            _id = 0;
            count = _id;
            return count;
        }


        public Employee(string fio, double salary, int otdel)
        {

            _fio = fio;
            _salary = salary;
            _otdel = otdel;
        }

        public string Fio
        {
            get => _fio;
            set => _fio = value;
        }
        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public int Otdel
        {
            get => _otdel;
            set => _otdel = value;
        }
    }
}
