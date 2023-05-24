using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            Controller controller = new Controller(targetNumber);

            IView view = new View(targetNumber, controller);

            controller.Run(view);
        }
    }
}