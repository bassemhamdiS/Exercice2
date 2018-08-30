using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{
    public class MessageC : Message
    {
        public override void CustomMessage()
        {
            MyCustomMessageOnC();
        }

        private void MyCustomMessageOnC()
        {
            Console.WriteLine("Message from C");
        }
    }
}
