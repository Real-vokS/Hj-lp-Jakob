using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
    class MessageManager
    {
        MessageHtmlConverter mhc;

        public void sendMessage(MessageType.MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageType.MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = mhc.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageType.MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = mhc.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void sendMessageToAll(MessageType.MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageType.MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = mhc.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageType.MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = mhc.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}
