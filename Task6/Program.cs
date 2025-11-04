public class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>() { "Pomegrante", "Strawberry", "Kiwi" };

        fruits.Add("Orange");

        fruits.Remove("Kiwi");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
        {
            { 1, "Pomegrante" },
            { 2, "Strawberry" },
            { 3, "Orange" }
        };

        
        fruitDictionary.Add(4, "Blueberry");

       
        Console.WriteLine("\nFruit Dictionary:");
        foreach (var item in fruitDictionary)
        {
            Console.WriteLine("ID: " + item.Key + " Fruit: " + item.Value);
        }
    }
}