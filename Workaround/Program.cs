//Citizen citizen1 = new Citizen();

Variables();
//arrayler /arrays

string student1 = "Alyar";
string student2 = "Green";
string student3 = "Ali";

string[] students = new string[3];
students[0] = student1;
students[1] = student2;
students[2] = student3;

//ramda iki bolum var stack ve heap 
//garbage collector heap terefi silir ilk newlediyimiz ornek 101 adresini.
//bunlar ozu her biri stackda dayanib heapde deyerleri referans olaraq tutur ve referans tipdir
//array, class, interface, abstract.
//students = new string[4];
//students[3] = "Ramel";

string[] citys1 = new[] { "Baku", "Antalya", "Izmir" };
string[] citys2 = new[] { "Istanbul", "Çorum", "Ottawa" };

citys2 = citys1;
citys1[0] = "Miami";
//heapde eyni idni tuturlar
Console.WriteLine(citys2[0]);

int number1 = 17;
int number2 = 6;
number2 = number1;
number1 = 5;
//int, double, bool referans yox deyer tiplerdir.
Console.WriteLine(number2);


//for loop
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

foreach (string city in citys1)
{
    Console.WriteLine(city);
}

//Generic list array listden ferqli olaraq add olunduqda ozunden evvelki indexleri alib ozunde tutur ve son indexide ozunde elave edir.
List<string> newCitys1 = new List<string> { "Ankara", "Batumi", "Tokio" };
newCitys1.Add("Ottowa");
foreach (var city in newCitys1)
{
    Console.WriteLine(city);
}

Console.WriteLine(student1);
void Variables()
{
    string message = "Hi";
    double price = 1000000;
    int number = 100;
    bool loggedIn = false;

    string name = "Alyar";
    string surname = "Mammadov";
    int birthYear = 2002;
    long cID = 1234567890;

    Console.WriteLine(price * 1.18);
}

//pascal casing
public class Citizen
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Birthyear { get; set; }
    public long CID { get; set; }
}
