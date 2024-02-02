﻿
using Spectre.Console;
using System;
using System.IO;

Random rnd = new Random();
int randomnumbernumber = rnd.Next(50);
int randomnumber = rnd.Next(randomnumbernumber);
int usertries = 1;

string username = AnsiConsole.Ask<string>("Type in your username:");
string fileName = @"C:\CSFiles_mf\scoresguessinggame.txt";
string dirname = @"C:\CSFiles_mf";
QuestionNumber();


    void QuestionNumber()
{
    int randomusernumber = AnsiConsole.Ask<int>("Please guess a number between " + randomnumbernumber + " and 0:");
    if (randomusernumber < randomnumber)
    {
        Console.WriteLine("Your number is too low!");
        Console.WriteLine("Try again");
        Console.WriteLine("////////////////");
        usertries = (usertries + 1);
        QuestionNumber();
    }
    else if (randomusernumber > randomnumber)
    {
        Console.WriteLine("Your number is too high!");
        Console.WriteLine("Try again");
        Console.WriteLine("////////////////");
        usertries = (usertries + 1);
        QuestionNumber();
    }
    else if (randomusernumber == randomnumber)
    {
        Console.WriteLine("You guessed it, it was " + randomusernumber + " and you tried to guess it " + usertries + " times");
        if (Directory.Exists(dirname))
        {

        }
        else
        {
            Directory.CreateDirectory(dirname);
        }
        try
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                
                sw.WriteLine(username+ ":" +usertries);
            }
        }
        catch (Exception Ex)
        {
            Console.WriteLine(Ex.ToString());
        }

    }
}  



