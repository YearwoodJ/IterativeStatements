using System.ComponentModel.Design;

namespace IterativeStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            try
            {
                Console.WriteLine("Enter an ineger value between 1 and 100");
                int input = int.Parse(Console.ReadLine());


                if ((input >= 0) && (input <= 100))
                {
                    Console.WriteLine("Specify the series type: Even Or Odd");
                    String series = Console.ReadLine();

                    if (series == "Odd")
                    {
                        Console.WriteLine("You have selecrted " + series + "Series. The numbers between 0 and " + input + " are: ");
                        for (int i = 1; i < input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    if (series == "Even")
                    {
                        Console.WriteLine("You have selected " + series + "Series. The numbers between 0 and " + input + " are: ");
                        for (int i = 0; i < input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    
                }
                else
                {
                    Console.WriteLine("Please Enter an integer between 1 and 100");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
            }
            catch
                {
                Console.WriteLine("Please insert a value between 1 and 100 and try again");
                Console.WriteLine("Press any Key to exit");
                Console.ReadKey(true);
            }
        }
    }
}