using System;

namespace DiceRollTestingGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DiceRoll();
        }
        static void DiceRoll()
        {
			Random firstDiceRollNum = new Random();
            Random secondDiceRollNum = new Random();

			Console.WriteLine("How many sides does the dice have?");
            int NumberedSidesOfDice = int.Parse(Console.ReadLine());

			string userResponse = "";
            Console.WriteLine("Do you want to roll the dice?(Yes or No)");
			userResponse = Console.ReadLine();
			if (userResponse == "Yes")
			{
				Console.WriteLine(firstDiceRollNum.Next(0, NumberedSidesOfDice));
				Console.WriteLine(secondDiceRollNum.Next(0, NumberedSidesOfDice));
			}
			else
			{
				Console.WriteLine("ok bye bye");
			}
            
        }
    }
}
