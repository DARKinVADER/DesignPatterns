using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Receiver;

namespace CommandPattern.Command
{
    public class GarageDoorOpenCommand : ICommand
    {
        readonly GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.up();
        }
    }
}
