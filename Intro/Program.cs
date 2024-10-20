using Intro.Entities;
using Intro.DataAccess.Concrete;
using Intro.Business.Concrete;


// variables ---> camelCase
#region Variables

string message = "Krediler";
int term = 12;
double amount = 100000.5;

#endregion

#region Conditions
bool isAuthenticated = true;

// condition
if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Abdulkadir");
}
else
{
    Console.WriteLine("Sisteme giriş yap.");
}
#endregion

#region Arrays
string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };
string[] loans2 = new string[] { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5" };
string[] loans3 = new string[6];
#endregion




Console.WriteLine();
Console.WriteLine();

// new syntax
CourseManager courseManager = new(new EfCourseDal());
//Course[] courses = courseManager.GetAll();
List<Course> courses = courseManager.GetAll();

foreach (var course in courses)
{
    Console.WriteLine("Id: " + course.Id);
    Console.WriteLine("Course name: " + course.Name);
    Console.WriteLine("Description: " + course.Description);
    Console.WriteLine("Price: " + course.Price);
    Console.WriteLine("-------------------------");
}

Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------");


IndividualCustomer customer1 = new IndividualCustomer()
{
    Id = 1,
    NationalIdentity = "12345678901",
    FirstName = "Aslı",
    LastName = "Karayiğit",
    CustomerNumber = "123456",
};

IndividualCustomer customer2 = new IndividualCustomer()
{
    Id = 2,
    NationalIdentity = "12345678902",
    FirstName = "Özgür",
    LastName = "Atılgan",
    CustomerNumber = "123457",
};

CorporateCustomer customer3 = new CorporateCustomer()
{
    Id = 3,
    CompanyName = "Kodlama.io",
    CustomerNumber = "654778",
    TaxNumber = "1254687963"
};

CorporateCustomer customer4 = new CorporateCustomer()
{
    Id = 4,
    CompanyName = "ABC",
    CustomerNumber = "654779",
    TaxNumber = "1254687967"
};




// ******** Base sınıflar, inherit edildiği sınıfın referansını tutabilir *********
// Polymorphism --> Customers dizisi, hem bireysel hem kurumsal müşterileri içermiştir. Çok biçimli olarak çalışabiliyor
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };



foreach (var customer in customers)
{
    if (customer is IndividualCustomer)
    {
        string id = ((IndividualCustomer)customer).NationalIdentity;
    }

    Console.WriteLine(customer.CustomerNumber);
}


