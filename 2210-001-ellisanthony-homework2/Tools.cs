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
            int delimPosition;
            while (line.Contains(delims))
            {
                delimPosition = line.IndexOf(delims[0])+1;
                Tokens.AddToken(line.Substring(0, delimPosition));
                line = line.Substring(delimPosition, line.Length - delimPosition);
                
            }
            Tokens.AddToken(line);
            return Tokens.GetTokens();
        }
        public static void TokenizeRecursive(Tokens tokens, String line, String Delimiters)
        {
            if (Delimiters == "")
            {
                tokens.AddToken(line);
                return;
            }
            String Delimiter=Delimiters.Substring(0, 1);
            int DelimiterIndex = line.IndexOf(Delimiter);
            String NewDelimiters = Delimiter.Substring(1);


        }

        public static void setup()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Title = "CSCI 2210 - Data Structures: Homework 2 by Anthony Ellis";
            
        }

        public static void display(String[] tokens)
        {
            for (int i = 0; i<tokens.Length && tokens[i] != null; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, tokens[i]);

            }
        }
        
    }
    class Tokens
    {
        List<String> tokens;
        public Tokens()
        {
            tokens = new List<String>();
        }
        public String[] GetTokens()
        {
            return tokens.ToArray();
        }
        public void AddToken(String NewToken)
        {
            tokens.Add(NewToken);
        }
    }
}
