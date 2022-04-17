using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IEmail
    {
        void sendEmail();
    }

    class OutlookEmail : IEmail
    {
        public void sendEmail()
        {
            Console.WriteLine("Sent outlook e-mail!");
        }
    }

    class WebServiceEmail : IEmail
    {
        public void sendEmail()
        {
            Console.WriteLine("Sent Webservice e-mail!");
        }
    }
}
