using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Alphamon
{
    class Arduino
    {
        private SerialMessenger SerialMessenger;
        private MessageBuilder MessageBuilder;
        private Timer readMessageTimer;
        public Arduino()
        {
            SerialMessenger.Connect();
            MessageBuilder messageBuilder = new MessageBuilder('#', '%');
            SerialMessenger = new SerialMessenger("COM5", 115200, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Elapsed +=(ReadMessageTimer_Tick);
        }
        private void ReadMessageTimer_Tick(object sender, ElapsedEventArgs e)
        {
            string[] messages = SerialMessenger.ReadMessages();
            if (messages != null)
            {
                foreach (string message in messages)
                {
                    processReceivedMessage(message);
                }
            }
        }
        private void processReceivedMessage(string message)
        {
            if (message == "ARDUINO_CONTROL")
            {
                
            }
            else if (message.StartsWith("RED_STATUS:"))
            {
                
            }
            else if (message.StartsWith("GREEN_STATUS:"))
            {
                
            }
            else if (message.StartsWith("BLUE_STATUS:"))
            {
               
            }
        }

    }
}
