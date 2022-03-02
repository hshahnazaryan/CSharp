class Program
{

    static bool prost = true;
    static int k = 2;
    static int n;
    static void Main(string[] args)
    {
        //Console.WriteLine((int)aaa.Monday);
        //var abc = aaa.Test1;
        //Console.WriteLine(abc);
        //aaa bb = new aaa();
        //Console.WriteLine("Arrival Status: {0} ({0:D})", bb);
        //var fbon = Fibonachi(70);// 1rst method fibonachi without recursion
        //Console.WriteLine(fbon);

        //Console.Write(NthFibonacciNumber(80));//2 nd wit recursion

        //var t = factorial(5);
        //Console.WriteLine(t);
        Console.WriteLine(a(1));
        string str = Console.ReadLine();
        PrintReverse(str);


        Console.WriteLine("Enter number\n");
        n = int.Parse(Console.ReadLine());
        Func(k);

        if (prost) Console.WriteLine("Prime");
        else Console.WriteLine("Not prime");

        Console.ReadKey();
    }

    public static int a(int ab)
    {
        int c;
        for (int i = 1; i <= 10; i++)
        {
            c = ab * i;
            Console.WriteLine(ab + " * " + i + " = " + c);
        }
        if (ab != 10)
            ab = a(ab + 1) * ab;
        return ab;
    }

    static void PrintReverse(string input)
    {
        if (input.Length > 0)
        {
            Console.Write(input[input.Length - 1]);
            PrintReverse(input.Substring(0, input.Length - 1));
        }
        else Console.Write(".");
    }


    static void Func(int k)
    {
        if (k < (n / 2))
            if (n % k == 0)
                prost = false;
            else
            {
                k++;
                Func(k);
            }
    }

    //public static int NthFibonacciNumber(int n)
    //{
    //    if ((n == 0) || (n == 1))
    //    {
    //        return n;
    //    }
    //    else
    //    {
    //        return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
    //    }
    //}
    //public static long Fibonachi(int n)
    //{
    //    int firstnumber = 0, secondnumber = 1, result = 0;
    //    //if (n == 0) return 0; //return the first  number   
    //    //if (n == 1) return 1; //return the second  number 

    //    for (int i = 2; i <= n; i++)
    //    {
    //        result = firstnumber + secondnumber;
    //        firstnumber = secondnumber;
    //        secondnumber = result;
    //    }

    //    return result;
    //}
    //public static int factorial(int i)
    //{
    //    int result;

    //    if (i == 1)
    //        return 1;
    //    result = factorial(i - 1) * i;
    //    return result;
    //}

    public enum aaa
    {
        Monday = 2,
        Test1,
        test2,
        test3 = 9,
        test4 = 8,
        test5
    }
}