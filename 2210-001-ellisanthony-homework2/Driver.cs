using System;
using System.Collections.Generic;
using System.Text;

namespace _2210_001_ellisanthony_homework2
{
    class Driver
    {
        public Driver()
        {
            string input = "this is my sample string! to!be!used/here";
            string delims = "!/";
            Tools.Tokenize(input, delims);
        }
    }
}
