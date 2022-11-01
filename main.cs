// Created by: Ekaterina
// Created on: Oct 2022
//
// This program calculates volume of a pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        decimal length;
        decimal width;
        decimal height;
        decimal volume;

        Console.WriteLine("This program calculates the volume of pyramid");
        Console.WriteLine(" ");

        Console.WriteLine("Formula: V = (L × W × H) / 3 ");
        Console.WriteLine(" ");
        Console.Write("Enter length of length: ");
        length = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter length of width: ");
        width = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter length of height: ");
        height = Convert.ToDecimal(Console.ReadLine());

        volume = (length * width * height) / 3;

        Console.WriteLine(" ");
        Console.WriteLine("Your volume will be: " + volume.ToString("0.00") + " mm³");

        Console.WriteLine("\nDone.");
    }
}