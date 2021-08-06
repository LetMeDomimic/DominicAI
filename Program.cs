using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Title = "Dominic AI";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("\t\t██████╗  ██████╗ ███╗   ███╗██╗███╗   ██╗██╗ ██████╗     █████╗ ██╗ ");
            Console.WriteLine("\t\t██╔══██╗██╔═══██╗████╗ ████║██║████╗  ██║██║██╔════╝    ██╔══██╗██║");
            Console.WriteLine("\t\t██║  ██║██║   ██║██╔████╔██║██║██╔██╗ ██║██║██║         ███████║██║");
            Console.WriteLine("\t\t██║  ██║██║   ██║██║╚██╔╝██║██║██║╚██╗██║██║██║         ██╔══██║██║");
            Console.WriteLine("\t\t█████╔╝╚██████╔╝ ██║ ╚═╝ ██║██║██║ ╚████║██║╚██████╗    ██║  ██║██║");
            Console.WriteLine("\t\t╚═════╝  ╚═════╝ ╚═╝     ╚═╝╚═╝╚═╝  ╚═══╝╚═╝ ╚═════╝    ╚═╝  ╚═╝╚═╝\n");

            
            
            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            Console.Write("Hello " + userName + ", nice to meet you\n\n\n");

            Console.WriteLine("Hey {0} how are you on this fine day? Press 1 for Good or 2 for bad.", userName);

int result;

if (int.TryParse(Console.ReadLine(), out result))

{

    if (result == 1)

        Console.WriteLine("Well {0} I am glad to hear it, cool!", userName);

    else if (result == 2)

        Console.WriteLine("Well {0} I am sorry to hear it, that sucks!", userName);   

    else

        Console.WriteLine("Incorrect response");

}

else

    Console.WriteLine("Incorrect response");

Console.ReadLine();


            

            


            Console.WriteLine("Hey " + userName + " whats your favorite color");

            string userColor = Console.ReadLine();

            Console.Write("Really? " + userColor + " is my favorite color to.\n\n\n");

            

            Console.WriteLine("Hey " + userName + " how old are you?");

            string userAge = Console.ReadLine();

            Console.Write("Really I'm " + userAge + " as well, what a small world we live in.\n\n\n" );

            

            Console.WriteLine("Hey " + userName + " whats your favorite video game, I like RDR2 alot");

            string userGame = Console.ReadLine();

            Console.Write("I do really like " + userGame + " alot to\n\n\n");


            Console.WriteLine("How the weather right now?");

            string userWeather = Console.ReadLine();

            Console.Write(userWeather + " nice\n\n\n");
            
            
            Console.WriteLine("Now that I have got to know you and you have gotten to know me do you want to be friends?, Press 3 for yes or 4 for no.");

int results;

if (int.TryParse(Console.ReadLine(), out results))

{

    if (results == 3)

        Console.WriteLine("Yay I'm glad we get to be friends!", userName);

    else if (results == 4)

        Console.WriteLine("Oh I understand", userName);   

    else

        Console.WriteLine("Incorrect response");

}



            Console.ReadKey();
        }
    }
}
