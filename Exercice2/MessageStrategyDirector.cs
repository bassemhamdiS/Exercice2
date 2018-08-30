using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{
    public class MessageStrategyDirector
    {
        private Message _message;
        public MessageStrategyDirector(Message message)
        {
            _message = message;
        }

        public void CustomMessage()
        {
            _message?.CustomMessage();
        }

    }
}
