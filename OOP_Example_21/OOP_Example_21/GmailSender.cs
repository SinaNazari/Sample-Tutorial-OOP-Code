﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_21
{
    public class GmailSender : IEmailSender
    {
        public void SendEmail(string email)
        {
            Console.WriteLine("Send From Gmail ...");
        }
    }
}
