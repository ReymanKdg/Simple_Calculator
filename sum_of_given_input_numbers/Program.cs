// See https://aka.ms/new-console-template for more information
int sum = 0;
int num = 0;

while(num != -1)
{
    Console.WriteLine("Please enter the sum of numbers to be calculated and press -1 for exit:");
    num = Convert.ToInt32(Console.ReadLine());
    //nested if statement 
    if(num != -1)
    {
    sum += num;
    }
}
    Console.WriteLine($"The sum is: {sum}");
Console.WriteLine("Thank you!!!");