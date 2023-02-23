using System.Security.Cryptography.X509Certificates;

internal class Program
{

    // Creating a public method for user's prompts
    private static int[] UserPrompts()
    {        
        Console.WriteLine("Enter the first number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int num2 = int.Parse(Console.ReadLine());
        int[] Prompts = { num1, num2 };
        return Prompts;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hey! Welcome to the calculator where you can solve your daily operations\n");    

        while (true)
        {
            Console.WriteLine(
            "Please, select the required operation\n" +
            "\n" +
            "1 - Sum\n" +
            "2 - Substraction\n" +
            "3 - Multiplication\n" +
            "4 - Division\n" +
            "\n" +
            "Or you can exit pressing '5' on your keyboard\n"
            );

            // Declaring menu variable
            int op = int.Parse(Console.ReadLine());

            // Entering in the options
            switch (op)
            {
                case 1:
                    int[] SumNum = UserPrompts();
                    int SumResult = SumNum[0] + SumNum[1];
                    Console.WriteLine($"The result is: {SumResult}\n");
                    break;

                case 2:
                    int[] SubNum = UserPrompts();
                    int SubResult = SubNum[0] - SubNum[1];
                    Console.WriteLine($"The result is: {SubResult}\n");
                    break;

                case 3:
                    int[] MulNum = UserPrompts();
                    int MulResult = MulNum[0] * MulNum[1];
                    Console.WriteLine($"The result is: {MulResult}\n");
                    break;

                case 4:
                    int[] DivNum = UserPrompts();
                    double DivResult = (double)DivNum[0] / DivNum[1];
                    Console.WriteLine($"The result is: {DivResult} \n");
                    break;

                default:
                    break;
            }
            if (op == 5)
            {
                Console.WriteLine("Thanks for use this app :D");
                break;
            }
        }        
    }
}