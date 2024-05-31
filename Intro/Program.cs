using Intro.Business;
using Intro.Entities;

string message = "Krediler";


int term = 12;
double amount = 100000.5;

// variables ---> camelCase
bool isAuthenticated = true;


// condition

if (!isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Abdulkadir");
}
else
{
    Console.WriteLine("Sisteme giriş yap.");
}


string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };


string[] loans2 = new string[] { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };

string[] loans3 = new string[6];









Console.WriteLine();
Console.WriteLine();


// new syntax
CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();

foreach (var course in courses)
{
    Console.WriteLine("Id: " + course.Id);
    Console.WriteLine("Description: " + course.Description);
    Console.WriteLine("Price: " + course.Price);
    Console.WriteLine("-------------------------");
}

