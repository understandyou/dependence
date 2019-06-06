using System;
using System.Collections.Generic;
using System.Text;

namespace mes
{
    public class Message : IMessage
    {
        public void write()
        {
            Console.WriteLine("--1--");
        }
    }
}
