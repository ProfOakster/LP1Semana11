using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View : IView
    {
        private readonly int targetNumber;
        private readonly Controller controller;

        public View(int targetNumber, Controller controller)
        {
            this.targetNumber = targetNumber;
            this.controller = controller;
        }






        
    }
}