public class Program
{
    static void Main(string[] args)
    {
        byte myByte = 255;
        short myShort = 32000;
        int myInt = 42;
        long myLong = 1234567890L;
        float myFloat = 3.14F;
        double myDouble = 3.14159265359;
        decimal myDecimal = 10.5M;
        char myChar = 'A';
        bool myBool = true;


        string convertInttoString = myInt.ToString();

        string strNumber = "3.14";
        double stringToDouble = Convert.ToDouble(strNumber);

        Console.WriteLine("byte: " + myByte);
        Console.WriteLine("short: " + myShort);
        Console.WriteLine("int: " + myInt);
        Console.WriteLine("long: " + myLong);
        Console.WriteLine("float: " + myFloat);
        Console.WriteLine("double: " + myDouble);
        Console.WriteLine("decimal: " + myDecimal);
        Console.WriteLine("char: " + myChar);
        Console.WriteLine("bool: " + myBool);

        Console.WriteLine("Integer to string: " + convertInttoString);
        Console.WriteLine("String \"3.14\" to double: " + stringToDouble);
    }
}
