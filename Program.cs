using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = "";
            var inputnum = 0;
            //Ask for number
            Console.WriteLine("Please enter a number, press enter when done?");
            //User input of number.
            num = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            //Input write
            Console.WriteLine($"Your Number is {num}");
            //loop it
            var isNumber = int.TryParse(num, out inputnum);
            for (var table = 0; table <= 12; table++)
            {
                //Print input times table up to 12 
                Console.WriteLine(inputnum * table);
            }
            Console.WriteLine(Environment.NewLine);
            for (var table = 0; table <= 12; table++)
            {
                //Print the stages
                Console.WriteLine("Stage {0}*{1}={2}", num, table, inputnum * table);
            }
            //Close program
            Console.ResetColor();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            //done..


        }
    }
}
