﻿using System;

public class Dice 
{
    /*
        rolls dice as a string input <n1>d<n2> where n1 is the number of dice, n2 is the number of faces on the dice and D is a delimitter 
    */
    public Dice() 
    { 
    
    }

    public int roll(string inString) 
    {
        int val = 0;
        Random rnd = new Random() ; 

        var diceNums = inString.Split('d');

        int numOfDice = Convert.ToInt32(diceNums[0]);
        int sizeOfDice = Convert.ToInt32(diceNums[1]);

        for (int i = 0; i < numOfDice; i++) 
        { 
            val += rnd.Next(1, sizeOfDice);
        }

        return val;
    }
}