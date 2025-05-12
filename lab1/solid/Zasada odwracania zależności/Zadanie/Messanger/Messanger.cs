using System;
using Messanger.Enum;
using Messanger.Logic;

namespace Messanger
{
    public class Messenger
    {
        private Sms _sms { get; set; }
        private Fax _fax { get; set; }
        private Email _email { get; set; }

        public void SendMessage(TypeMessage type)
        {
            switch (type)
            {
                case TypeMessage.Email:
                    _email = new Email();
                    _email.SendEmail();
                    break;

                case TypeMessage.Sms:
                    _sms = new Sms();
                    _sms.SendSMS();
                    break;

                case TypeMessage.Fax:
                    _fax = new Fax();
                    _fax.SendFax();
                    break;
            }
        }
    }
}
