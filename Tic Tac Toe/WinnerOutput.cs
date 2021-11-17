using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class WinnerOutput // Create at least ONE CLASS
    {
        public string Message // Create at least ONE OBJECT of the CLASS ( see WinnerOutput )
        {
            get { return Message; } // Populate the OBJECT with data ( see Message ) 
            set
            {
                if (value == "Game Over, Players!") // Use or display the data in your application ( e.g. a class to hold and display winner information )
                { Message = value; }
            }
        }
    }
}




