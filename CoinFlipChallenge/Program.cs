using System;
using System.Linq.Expressions;


public class Program
{



    public static void Main()
    {
        string name;
        int score = 0;
        string guess;
        int human_value;
        


        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE? Yes/No");
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        string response = Console.ReadLine();
        Random random = new Random();

        if (response == "Yes" || response == "yes" || response == "YES")
        {
            Console.WriteLine("Heads or Tails?");
            for (int i = 0; i < 5; i++)
            {

                guess = Console.ReadLine();

                if (guess == "Heads" || guess == "heads" || guess == "HEADS")
                {
                    human_value = 1;

                }

                else if(guess == "Tails" || guess == "tails" || guess == "TAILS")
                {
                    human_value = 0;

                }

                else
                {
                    Console.WriteLine("Try Again");
                    i--;
                    continue;   //restarts the loop
                }

               
                int random_num = random.Next(0, 1);

                if (random_num == human_value)
                {
                    score++;
                    Console.WriteLine("Correct!");
                }

                else
                {
                    Console.WriteLine("Wrong!");
                }




            } // loop ends here

            Console.WriteLine("Thank you " + name + ". You got a score of " + score + "! ");

        } // end of the game






















        else 
        {
            Console.WriteLine("You are a Coward " + name);   // never played the game
        }

    }
}