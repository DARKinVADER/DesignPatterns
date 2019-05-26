using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Receiver;

namespace CommandPattern.Command
{
    public class LightOnCommand : ICommand
    {
        private readonly Light light;
        public LightOnCommand(Light light)
        {
            this.light = light ?? throw new ArgumentNullException(nameof(light));
        }
        public void Execute()
        {
            light.on();
        }
    }
}
