//Array

////Ask user for the array size 
//Console.WriteLine("Enter the number of Grades to entered:");
//int numberOfGrades = Convert.ToInt32(Console.ReadLine());

////Declare array
//int[] grades = new int[numberOfGrades];
//string[] students = new string[numberOfGrades];

//for (int i = 0; i < numberOfGrades; i++)
//{
//    Console.WriteLine("Enter Student Name:");
//    students[i] = Console.ReadLine();

//    Console.WriteLine("Enter Grade:");
//    grades[i] = Convert.ToInt32(Console.ReadLine());
//}

////print the values in array
//for (int i = 0; i < numberOfGrades; i++)
//{
//    Console.WriteLine($"{students[i]} : {grades[i]}");
//}


//List

//Declare List
List<int> grades = new List<int>();
List<string> students = new List<string>();
int grade = 0;
string name;
int gradeCount = 0;
int @continue; // we can name the keyword simply by giving @ in the front of that keyword


do
{
    gradeCount += 1;
    Console.WriteLine("Enter Student name:");
    name = Console.ReadLine();
    students.Add(name);

    Console.WriteLine("Grade:");
    grade = Convert.ToInt32(Console.ReadLine());
    if (grade != -1)
    {
    grades.Add(grade);
    }

    Console.WriteLine("Do you want to continue? (1=yes | 2=no):");
    @continue = Convert.ToInt32(Console.ReadLine());
}
while (@continue == 1);

//Print the calues in lists
Console.WriteLine("The Grades you have entered are:");
for(int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"{students[i]} : {grades[i]}");
}