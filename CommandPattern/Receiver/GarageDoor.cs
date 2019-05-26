namespace CommandPattern.Receiver
{
    public class GarageDoor
    {
        internal void up()
        {
            System.Console.WriteLine(@"Garagedoor went up!");
        }
        void down() { }
        void stop() { }
        void lightOn() { }
        void lightOff() { }
    }
}