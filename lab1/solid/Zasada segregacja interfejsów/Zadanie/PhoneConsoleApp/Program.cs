using System;
using System.Collections.Generic;
using Phone.Logic;
using Phone.Logic.Abstract;
using Phone.Logic.Concrete;
using PhoneExampleSolution.Logic;

namespace PhoneConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var iphone = new IPhone8();
            var employee = new Employee();
            employee.WriteText(iphone, "Test",12222);
            employee.ShowGps(iphone);
        }
    }
}
