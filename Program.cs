class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Login { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string firstName, string lastName, int age, string login)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Login = login;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Information about user:");
        Console.WriteLine($"Name: {FirstName}");
        Console.WriteLine($"LastName: {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Login: {Login}");
        Console.WriteLine($"Registration Date: {RegistrationDate}");
    }
}

class Program
{
    static void Main()
    {
        User user = new User("Данило", "Бабак", 19, "dankababak");

        user.DisplayUserInfo();
    }
}
