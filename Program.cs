namespace SnakeLadderUCs
{
    internal class Program
    {
        public static void WelcomeMsg()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
        }
        static void Main(string[] args)
        {
            WelcomeMsg();
            int position = 0;
            Console.WriteLine($"Initial starting position of Player :{position}");
        }
    }
}