using System;

class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public User(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Электронная почта: {Email}");
        Console.WriteLine($"Возраст: {Age}");
    }
}

class Program
{
    // сумма
    static int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    // частное
    static double Dev(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new DivideByZeroException("На ноль делить нельзя.");
        }

        return firstNumber / secondNumber;
    }

    static void Main()
    {
        Console.WriteLine($"Сумма: {Add(10, 5)}");
        Console.WriteLine($"Частное: {Dev(10, 5)}");

        User user = new User("Анна", "anna@gmail.com", 20);
        user.ShowInfo();
    }
}
