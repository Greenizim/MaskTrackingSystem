Citizen citizen1 = new Citizen();


Variables();

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
