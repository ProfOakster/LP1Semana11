using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {
        private readonly int targetNumber;
        private IView view;

        public Controller(int targetNumber)
        {
            this.targetNumber = targetNumber;
        }

        public void Run(IView view)
        {
            this.view = view;
        }
    }
}