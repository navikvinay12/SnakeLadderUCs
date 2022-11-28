namespace SnakeLadderUCs
{
    internal class SnakeLadder
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
        public static int GameBoardAndPosition()
        {
            int position = 0;
            Random random = new Random();
            int diceOutput = SnakeLadder.DiceThrown();

            while (position >= 0 && position < 100)
            {
                SnakeLadder invokingConstructor = new SnakeLadder();
                int checksNewPosition = random.Next(3);
                switch (checksNewPosition)
                {
                    case 0:
                        Console.WriteLine("Ladder");
                        position = position + diceOutput;
                        break;
                    case 1:
                        Console.WriteLine("Snake");
                        position = position - diceOutput;
                        if (position < 0)      
                        {
                            position = 0;   //if player moves below 0 then it will set the position to 0 only .
                        }
                        break;
                    default:
                        Console.WriteLine("No Play");
                        break;
                }
                Console.WriteLine("Position :" + position);
            }
            return position;
        }
        static void Main(string[] args)
        {
            WelcomeMsg();
            Console.WriteLine("Position :" + GameBoardAndPosition());
        }
    }
}