using System;
using System.Collections.Generic;
using System.Text;

namespace _2210_001_ellisanthony_homework2
{
    class Tools
    {
       
         public static String[] Tokenize(string line, string delims)
        {

            Tokens Tokens = new Tokens();
            int EndOfLine = line.Length;
            int CurrentPosition = 0;
            while (CurrentPosition < EndOfLine)
            {
                

            }
            return Tokens.GetTokens();
        }
        
    }
    class Tokens
    {
        String[] tokens;
        int Curr;
        public Tokens()
        {
            tokens = new string[10];
            Curr = 0;
        }
        public String[] GetTokens()
        {
            return tokens;
        }
        public void AddToken(String NewToken)
        {
            if (Curr == tokens.Length - 1)
            {
                resize();
            }
            tokens[Curr] = NewToken;
            Curr++;
        }
        private void resize()
        {
            String[] temp = new string[tokens.Length * 2];
            int TempCurr = 0;
            foreach(String token in tokens){
                temp[TempCurr] = token;
            }
            tokens = temp;
        }
    }
}
