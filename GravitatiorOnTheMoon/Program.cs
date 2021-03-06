﻿/* Problem 2. Gravitation on the Moon
 * The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Title = "Problem 2. Gravitation on the Moon";

        Console.Write("Weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Weight on the Earth: {0} ", weight);
        Console.WriteLine("Weight on the Moon: {0} ", weight * 0.17);
    }
}

