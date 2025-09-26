// See https://aka.ms/new-console-template for more information
//Welcome Message
//github account added
Console.WriteLine("************WELCOME TO SIMPLE CALCULATOR************");

int choice = 0;
int num1, num2 = 0;
while (choice != -1)
try
{
        //Show calculators menu.

        PrintMenu();
 
        if (choice == -1)
        {
            break;
        }
         //Prompt for user input
            Console.WriteLine("Please enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = AddNumbers(num1, num2); 
                Console.WriteLine($"The addition of {num1} + {num2} is : {answer}");
                break;
            case 2:
                answer = SubtractNumbers(num1, num2);
                Console.WriteLine($"The subtraction of {num1} - {num2} is : {answer}");
                break;


            case 3:
                answer = MultiplyNumbers(num1, num2);
                Console.WriteLine($"The multiplication of {num1} * {num2} is : {answer}");
                break;

            case 4:
                answer = DivisionNumbers(num1, num2);
                Console.WriteLine($"The division of {num1} / {num2} is : {answer}");
                break;

            case 5:
                answer = ModulusNumbers(num1, num2);
                Console.WriteLine($"The modulus of {num1} % {num2} is : {answer}");
                break;

            case 6:
                answer = FibbNumbers(num1, num2);
                Console.WriteLine($"The fibinacci sum of {num1} and {num2} is: {answer}");
                break;

            default:
                throw new Exception("Invalid!!!!");
        }
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
       
    }
    finally
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();
    }


Console.WriteLine("**********THANK YOU!!!!*********");
   
//Method definition
int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}
int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}
int MultiplyNumbers(int num1, int num2)
{
    return num1 * num2;
}
int DivisionNumbers(int num1, int num2)
{
    return num1 / num2;
}
int ModulusNumbers(int num1, int num2)
{
    return num1 % num2;
}
int FibbNumbers(int num1, int num2)
{
    int answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}


void PrintMenu()
{
    Console.WriteLine("Please select the options 1-6 and press -1 to exit!!!!");
    Console.WriteLine("1.Addition");
    Console.WriteLine("2.Subtraction");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Division");
    Console.WriteLine("5.Modulus");
    Console.WriteLine("6.Fibonacci Sequence");
    choice = Convert.ToInt32(Console.ReadLine());
}