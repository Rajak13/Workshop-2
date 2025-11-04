public class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2005, 1, 24);

        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int age = ageSpan.Days / 365;
        
        Console.WriteLine("Birthdate: " + birthDate);
        Console.WriteLine("Current Date: " + currentDate);
        Console.WriteLine("Your Age: " + age + " years");


        DateTime add10BirthDate = birthDate.AddDays(10);
        Console.WriteLine("Birthdate plus 10 days: " + add10BirthDate);
    }
}