class Program
{
    static void Main(string[] args)
    {
        //1
        User();

        //2
        Console.Write("Name: ");
        string name = Console.ReadLine();
        UserName(name);

        //3
        Console.Write("Number: ");
        string n1 = Console.ReadLine();
        Console.Write("Number2: ");
        string n2 = Console.ReadLine();
        SumTwoNumbers(n1, n2);

        //4
        Console.Write("Input a string: ");
        string Text = Console.ReadLine();
        SpacesInText(Text);

        //5
        SumArray();

        //6
        Console.Write("Number: ");
        string sN1 = Console.ReadLine();
        Console.Write("Number2: ");
        string sN2 = Console.ReadLine();
        SwapNumbers(sN1, sN2);

        //7
        Console.Write("Base number: ");
        string exN1 = Console.ReadLine();
        Console.Write("Exponent: ");
        string ex2 = Console.ReadLine();
        ExponentNumbers(exN1, ex2);

        //8
        Console.Write("Input number of Fibonacci Series: ");
        string fbNum1 = Console.ReadLine();
        FibonacciNumbers(fbNum1);

        //9
        Console.Write("Input a number: ");
        string prN1 = Console.ReadLine();
        PrimeNumbers(prN1);

        //10
        Console.Write("Enter a number: ");
        string siNum1 = Console.ReadLine();
        SumIndividual(siNum1);

        //Array With Method Values
        string outPar1 = "";
        string text1 = "Method1";
        string outPar2 = "";
        string text2 = "Method2";
        string[] arr = new string[2] { Method1(text1, ref outPar1), Method2(text2, ref outPar2) };
        Console.WriteLine($"{outPar1}{arr[0]}");
        Console.WriteLine($"{outPar1}{arr[1]}");
    }

    public static void User()
    {
        Console.WriteLine("Welcome Friends!");
        Console.WriteLine("Have a nice day!");
    }
    public static void UserName(string name)
    {
        Console.WriteLine($"Welcome friend {name}!");
        Console.WriteLine("Have a nice day!");
    }
    public static void SumTwoNumbers(string num1, string num2)
    {
        int.TryParse(num1, out int _num1);
        int.TryParse(num2, out int _num2);
        Console.WriteLine($"The sum of two numbers is: {_num1 + _num2}");
    }
    public static void SpacesInText(string text)
    {
        int spaceCount = text.Split(" ").Length - 1;
        Console.WriteLine($"{text}: {spaceCount}");
    }
    public static void SumArray()
    {
        int[] array = new int[5] { 5, 7, 3, 2, 9 };
        int sumResult = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumResult += array[i];
        }
        Console.WriteLine($"The sum of the elements of the array is {sumResult}");
    }
    public static void SwapNumbers(string num1, string num2)
    {
        int.TryParse(num1, out int _num1);
        int.TryParse(num2, out int _num2);

        int otherNum = _num1;
        _num1 = _num2;
        _num2 = otherNum;

        Console.WriteLine($"Now the 1st number is: {_num1}, and the 2nd number is: {_num2}");
    }
    public static void ExponentNumbers(string num1, string num2)
    {
        double.TryParse(num1, out double _num1);
        double.TryParse(num2, out double _num2);
        double result = Math.Pow(_num1, _num2);
        Console.WriteLine($"So, the number {_num1}^(to the power){_num2} = {result}");
    }
    public static void FibonacciNumbers(string series)
    {
        int.TryParse(series, out int _series);
        Console.Write($"The Fibonacci series of {_series} numbers is: ");

        int i = 0;
        int numF = 0;
        int numL = 1;
        while (i < _series)
        {
            Console.Write($"{numF} ");
            int num = numF + numL;
            numF = numL;
            numL = num;
            i++;
        }
    }
    public static void PrimeNumbers(string num1)
    {
        decimal.TryParse(num1, out decimal _num1);
        Console.WriteLine("The number {0} {1} prime", _num1, (_num1 % 2 == 0 ? "is" : "is not"));
    }
    public static void SumIndividual(string num1)
    {
        int num = 0;
        for (int i = 0; i < num1.Length; i++)
        {
            int.TryParse(num1[i].ToString(), out int res);
            if (res > 0)
                num += res;
        }
        Console.WriteLine($"The sum of the digits of the number {num1} is: {num}");
    }
    public static string Method1(string text, ref string outPar)
    {
        outPar = "Method name is: ";
        return text;
    }
    public static string Method2(string text, ref string outPar)
    {
        outPar = "Method name is: ";
        return text;
    }
}