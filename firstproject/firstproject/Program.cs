string clientFirstName;
string clientLastName;
string clientMiddleName;

Console.WriteLine("Как Вас зовут?");
clientFirstName = Console.ReadLine();
Console.WriteLine("Привет, "+ clientFirstName + "!!!");

Console.WriteLine("Какая у Вас фамилия?");
clientLastName = Console.ReadLine();

Console.WriteLine("Какое у Вас отчество?");
clientMiddleName = Console.ReadLine();

string clientAllName=clientFirstName+" "+clientLastName+" "+clientMiddleName;
Console.WriteLine(clientAllName);


