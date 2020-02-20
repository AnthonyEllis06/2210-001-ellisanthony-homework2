//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Homework 2 - String handling exercise
//	File Name:		Tools.cs
//	Description:	Used to turn a string into a multiple tokens
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Anthony Ellis, ellisah@etsu.edu, East Tennessee State University
//	Created:		Tuesday, Febuary 018, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

namespace _2210_001_ellisanthony_homework2
{


    /// <summary>
    /// The static Methods are used to split strings up and display them.
    /// </summary>
    class Tools
    {
       
        /// <summary>Tokenizes the specified line.</summary>
        /// <param name="line">A multichar String that is  going to be tokenized</param>
        /// <param name="delims"> The String containing the delimiters to be used to tokenize the line</param>
        /// <returns>Returns the tokenized version of line as an array of strings</returns>
        public static String[] Tokenize(string line, string delims)
        {   
            List<String> Tokens= new List<String>();// Tokens is a collection that uses a list and has helper methods for adding a string token
            String Token; //Holds the currnet string token to be added
            char[] DelimChars = delims.ToCharArray(); //Array of chars made of the delims string
            int CurrDelimPosition = line.IndexOfAny(DelimChars); //the current position of the delimiter in the string
            while (CurrDelimPosition != -1)//used to find all the delimiters untill none are found
            {
                if (CurrDelimPosition == 0)//In case delimiter is the next token
                    CurrDelimPosition = 1;
                Token = line.Substring(0, CurrDelimPosition);
                if(!String.IsNullOrWhiteSpace(Token))//checks if token is a space
                    Tokens.Add(Token);
                line = line.Substring(CurrDelimPosition);//shortens line to rest of string
                CurrDelimPosition = line.IndexOfAny(DelimChars);
            }
            if (!String.IsNullOrWhiteSpace(line))
                Tokens.Add(line);//adds the final token
            return Tokens.ToArray();//Calls the tokens class to get an String array of the all the tokens
        }

        /// <summary>
        /// Sets up the display.
        /// </summary>
        public static void setup()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Enter text to be processed.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "CSCI 2210 - Data Structures: Homework 2 by Anthony Ellis";
            
        }

        /// <summary>
        /// Displays the specified tokens.
        /// </summary>
        /// <param name="tokens">A String Array Containing the String tokens to be displayed</param>
        public static void display(String[] tokens)
        {
            int LineNumber = 0;
            int Lines = Console.WindowHeight-5;//Number of Console Lines 
            DisplayTop();
            for (int i = 0; i<tokens.Length && tokens[i] != null; i++)//Iterates through Tokens to display
            {
                Console.WriteLine(" {0}.    {1}", i + 1, tokens[i]);//Sets format for each line
                if (LineNumber == Lines)//If Window line limit is reached
                {
                    DisplayBottom();
                    Console.Clear();
                    DisplayTop();
                    LineNumber = 0;//resets the current line in the window to 0
                }
                LineNumber++;
            }
            DisplayBottom();//Displays Bottom line for the last time
        }

        /// <summary>
        /// Sets Colors and Displays the Top then resets colors.
        /// </summary>
        private static void DisplayTop()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" No. Token");
            Console.WriteLine("---- ----");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        /// <summary>
        /// Sets Colors and Displays the bottom then resets colors.
        /// </summary>
        private static void DisplayBottom()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();//waits for any key to be pressed to continue
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
        } 
    }
}
