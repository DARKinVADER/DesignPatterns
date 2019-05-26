using System;
using CommandPattern.Command;
using CommandPattern.Receiver;

namespace CommandPattern
{
    public static class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

            remote.setCommand(lightOn);
            remote.buttonWasPressed();

            remote.setCommand(garageDoorOpen);
            remote.buttonWasPressed();
        }
    }
}
