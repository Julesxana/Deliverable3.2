/* Author: Juliana
  Date: 2/6/2020
  Deliverable 3.2 for week 4 of ISM 4300, Review of Methods
  */
using System;

namespace Deliverable3._2
{
    class Program
    {
        static void Main(string[] args)

        {//promt the user to enter their name
            Console.WriteLine("Please enter your name");
            try
            {
                //put the user input into a varible
                string Name = Console.ReadLine();
                HelloFriend(ref Name);

            }
            catch
            {
                //if error occurs ask the user to enter a valid name
                Console.WriteLine("Please enter a valid name");
            }
        }
        private static void HelloFriend(ref string Name)
        {
            //Display Hello name of the user
            Console.WriteLine("Hello "+ Name + "!");

        }
    }
}
