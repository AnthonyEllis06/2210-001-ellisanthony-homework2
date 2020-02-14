using System;
using System.Collections.Generic;
using System.Text;

namespace _2210_001_ellisanthony_homework2
{
    class Driver
    {
        public Driver()
        { 
            string delims = " !#2";
            //Tools.setup();
            string input = " ";
            while (input != "q")
            {
                input = Console.ReadLine();
                String[] tokens = Tools.Tokenize(input, delims);
                Tools.display(tokens);
            }

        }
    }
}
