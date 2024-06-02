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




Console.WriteLine("--------------------------------------------------------");






IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678901";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678902";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";




CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.CompanyName = "Kodlama.io";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "1254687963";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.CompanyName = "ABC";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "1254687967";



// Base sınıflar, inherit edildiği sınıfın referansını tutabilir
// bu olaya polimorfizm denir, customers dizisi, hem bireysel hem kurumsal müşterileri içermiştir.
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };



foreach (var customer in customers)
{
    
    Console.WriteLine(customer.CustomerNumber);
}


