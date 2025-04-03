using System;
using System.Collections.Generic;
using System.Text;
using Phone.Logic.Abstract;

namespace PhoneExampleSolution.Logic
{
    public class Employee
    {
        public string ShowPhoneModel(IPhone phone)
        {
          return  phone.Model;
        }

        public void ShowGps(IPhone navigable)
        {
            navigable.UseGPS();
        }
        public void WriteText(IPhone textable, string message, int number)
        {
            textable.Text(number, message);
        }
    }
}
