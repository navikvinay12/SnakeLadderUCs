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
                        if (position < 0)      //if player moves below 0 then will take it back to its previous position (UC4)
                        {
                            position = position + diceOutput;
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