namespace SnakeLadderUCs
{
    internal class Program
    {
        public static void WelcomeMsg()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
        }
        public static int DiceThrown()
        {
            Random random = new Random();
            int diceOutput = random.Next(1, 7);
            return diceOutput;
        }
        public static void Case()
        {
            Random random = new Random();
            int diceCheck = random.Next(1, 4);
            switch (diceCheck)
            {
                case 1:
                    Console.WriteLine("Ladder");
                    break;
                case 2:
                    Console.WriteLine("Snake");
                    break;
                default:
                    Console.WriteLine("No Play");
                    break;
            }
        }
        static void Main(string[] args)
        {
            WelcomeMsg();
            int position = 0;
            Console.WriteLine("Initial Position :" + position);
            Console.WriteLine("Dice Output :" + DiceThrown());
            Case();
        }
    }
}
