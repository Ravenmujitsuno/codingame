using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {

        // game loop
        int nextMountainArray = 99;
        while (true)
        {
            int nextMountain = 0;
            for (int i = 0; i < 8; i++)
            {
                
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                Console.Error.WriteLine($"input = {mountainH} vs nextMountain {nextMountain}");
                if (mountainH >= nextMountain)
                {
                    nextMountain = mountainH;
                    nextMountainArray = i;
                    Console.Error.WriteLine($"Array choosen: {nextMountainArray}");
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");



            Console.WriteLine(nextMountainArray); // The index of the mountain to fire on.
        }
    }
}