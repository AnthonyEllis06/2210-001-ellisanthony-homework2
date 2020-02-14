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
            int NumDelims = delims.Length-1;
            int delimPosition=0;
            int currDelimPosition;
            bool eol = false;
            while (!eol)
            {
                
                currDelimPosition = line.Length;
                delimPosition = currDelimPosition;
                for (int i = 0; i <= NumDelims; i++)
                {
                    currDelimPosition = line.Length;
                    if (line.Contains(delims[i]))
                    {
                        currDelimPosition = line.IndexOf(delims[i]);
                        eol = false;
                        
                    }
                    else
                    {
                        eol = true;
                    }
                    if (currDelimPosition < delimPosition)
                            delimPosition = currDelimPosition;
                    
                }
                
                Tokens.AddToken(line.Substring(0, delimPosition).Trim());
                line = line.Substring(delimPosition, line.Length - delimPosition);
                
                if(line[0].ToString() != " ")
                {
                    Tokens.AddToken(line[0].ToString());
                }
                line.Trim();
                line = line.Substring(1);
                
            }
            Tokens.AddToken(line);
            return Tokens.GetTokens();
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
