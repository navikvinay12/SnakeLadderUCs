namespace SnakeLadderUCs
{
    internal class SnakeLadder
    {
        public static int incrementingDice = 0;
        public SnakeLadder()
        {
            incrementingDice++;
        }
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
        public static int Case()
        {
            Random random = new Random();
            int diceCheck = random.Next(3);
            return diceCheck;
        }
        public static (int, int) GameBoardAndPosition()
        {
            {
                int pP1 = 0, pP2 = 0;
                int diceOutput = SnakeLadder.DiceThrown();

                while ((pP1 >= 0 && pP1 < 100) && (pP2 >= 0 && pP2 < 100))
                {
                Player1GotLadderSoRepeating:
                    SnakeLadder invokingConstructorp1 = new SnakeLadder();
                    int checksPositionP1 = Case();
                    switch (checksPositionP1)
                    {
                        case 0:
                            Console.WriteLine("Ladder");
                            pP1 = pP1 + diceOutput;
                            if (pP1 > 100)
                            {
                                pP1 = pP1 - diceOutput;   
                            }
                            if (pP1==100)
                            {
                                Console.WriteLine($"Player 1 Position is :{pP1}");
                                goto Player1WonSoTerminatingGame;
                            }
                            Console.WriteLine($"Player 1 Position is :{pP1}");
                            goto Player1GotLadderSoRepeating;
                        case 1:
                            Console.WriteLine("Snake");
                            pP1 = pP1 - diceOutput;
                            if (pP1 < 0)      
                            {
                                pP1 = pP1 + diceOutput;
                            }
                            break;
                        default:
                            Console.WriteLine("No Play");
                            break;
                    }
                    Console.WriteLine($"Player 1 Position is :{pP1}");
                    
                    Player2GotLadderSoRepeating:
                    SnakeLadder invokingConstructorp2 = new SnakeLadder();
                    int checksPositionP2 = Case();
                    switch (checksPositionP2)
                    {
                        case 0:
                            Console.WriteLine("Ladder");
                            pP2 = pP2 + diceOutput;
                            if (pP2 > 100)
                            {
                                pP2 = pP2 - diceOutput;   
                            }
                            if (pP2 == 100)
                            {
                                break;
                            }
                            Console.WriteLine($"Player 2 Position is :{pP2}");
                            goto Player2GotLadderSoRepeating;
                        case 1:
                            Console.WriteLine("Snake");
                            pP2 = pP2 - diceOutput;
                            if (pP2 < 0)      
                            {
                                pP2 = pP2 + diceOutput;
                            }
                            break;
                        default:
                            Console.WriteLine("No Play");
                            break;
                    }
                    Console.WriteLine($"Player 2 Position is :{pP2}");
                }
                Player1WonSoTerminatingGame:
                return (pP1, pP2);
            }
        }
        public static void WinnerPlayer(int pP1, int pP2)
        {
            if (pP1 > pP2)
            {
                Console.WriteLine($"Player 1 won as Player 1 reached {pP1}th position and Player 2 is still at Position {pP2}");
            }
            else
            {
                Console.WriteLine($"Player 2 won as Player 2 reached {pP2}th position and Player 1 is still at Position {pP1}");
            }
        }
        public static void DiceRollingCount()
        {
            Console.WriteLine($"No of times the Dice Rolled is : {SnakeLadder.incrementingDice}");
        }
        static void Main(string[] args)
        {
            WelcomeMsg();
            (int pP1, int pP2) = GameBoardAndPosition();
            WinnerPlayer(pP1, pP2);
            DiceRollingCount();
        }
    }
}