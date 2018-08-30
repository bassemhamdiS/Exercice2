using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{
    public class MessageB : Message
    {
        public override void CustomMessage()
        {
            MyCustomMessageOnB();
            SomeAdditonalMessageCustomMessageOnB();
        }

        private void MyCustomMessageOnB()
        {
            Console.WriteLine("Message from B");
        }

        private void SomeAdditonalMessageCustomMessageOnB()
        {
            Console.WriteLine("Some additional Message from B");
        }
    }
}
