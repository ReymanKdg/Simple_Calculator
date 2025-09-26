//Declare variables
string name = string.Empty;
int age = 0;
int retirement_age = 65;

//prompt for user
Console.WriteLine("Write your name:");
name = Console.ReadLine();

Console.WriteLine("Write your age:");
age = Convert.ToInt32(Console.ReadLine());

//Process
int workingyearsremaining = retirement_age - age;

//Output
Console.WriteLine($"Name:{name}");
Console.WriteLine($"Age:{age}");
Console.WriteLine($"Working Days left:{workingyearsremaining}");





