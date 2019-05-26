using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Command;

namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl()
        {
        }

        public void setCommand(ICommand command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.Execute();
        }
    }
}
