using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{
    public class MessageA : Message
    {
        public override void CustomMessage()
        {
            MyCustomMessageOnA();
        }

        private void MyCustomMessageOnA()
        {
            Console.WriteLine("Message from A");
        }
    }
}
