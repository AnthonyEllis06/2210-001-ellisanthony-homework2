//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Homework 2 - String handling exercise
//	File Name:		Driver.cs
//	Description:	Used to Test and Run the Static methods for the Poject
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
    /// Driver class that Calls the Static methods
    /// </summary>
    class Driver
    {
        public Driver()
        { 
            string delims = " !#2.@#%$@$#%";//String of delimiters to be used to deliminate
            string input = " ";
            while (input != "q")//run until user inputs "q"
            {
                Tools.setup();//Sets up the display
                input = Console.ReadLine();//get string to tokenize
                String[] tokens = Tools.Tokenize(input, delims);//Tokenize the string
                Tools.display(tokens);//Display the String
            }

        }
    }
}
