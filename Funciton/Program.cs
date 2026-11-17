class Programm
{
     static void message (string name, int age)
    {
        Console.WriteLine($"Name is: {name} and age is: {age}");
    }


    static void Main(string[] args)
    {
        message("Rayat", 25);
        message("Ashik", 21);
        message("Ridu", 21);
    }
}