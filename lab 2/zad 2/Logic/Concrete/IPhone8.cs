using System;
using System.Collections.Generic;
using System.Text;
using Phone.Logic.Abstract;

namespace Phone.Logic.Concrete
{
   public  class IPhone8 : IPhone,
    {
        public string Model { get; set; }

        public void Call(int number)
        {
        }

        public void Text(int number, string textMessage)
        {
        }

        public void TransferFiles(int blueId)
        {
        }

        public void ConnectInternet()
        {
        }

        public void UseGPS()
        {
           
        }
    }
}
