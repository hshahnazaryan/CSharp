
//If Else Loop
using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;
//int a = 8;
//int b = 12;
//int max;

//if (a > b)
//{
//    max = a;
//}
//else
//{
//    max = b;
//}
//Console.WriteLine("max=" + max);

//max = (a > b) ? a : b;
////You can simply write:
//int time = 20;
//string result = (time < 18) ? "Good day." : "Good evening.";
//Console.WriteLine(result);


////---------------------------------------------------------------------------
////Switch Case

//int day = 4;
//for (int j =0; j < 10;)
//{
//    switch (day)
//    {
//        case 1:
//            Console.WriteLine("Monday");
//            break;
//        case 2:
//            Console.WriteLine("Tuesday");
//            break;
//        case 3:
//            Console.WriteLine("Wednesday");
//            break;
//        case 4:
//            Console.WriteLine("Thursday");
//            break;
//        case 5:
//            Console.WriteLine("Friday");
//            break;
//        case 6:
//            Console.WriteLine("Saturday");
//            break;
//        case 7:
//            Console.WriteLine("Sunday");
//            break;
//    }

//    day++;
//}
//// Outputs "Thursday" (day 4)

////---------------------------------------------------------------------------------
////Switch case with break operator

//int today = 4;
//switch (today)
//{
//    case 6:
//        Console.WriteLine("Today is Saturday.");
//        break;
//    case 7:
//        Console.WriteLine("Today is Sunday.");
//        break;
//    default:
//        Console.WriteLine("Looking forward to the Weekend.");
//        break;
//}
//// Outputs "Looking forward to the Weekend."
////continue
////-------------------------------------------------------------------
////DO WHile and While do
//int i = 0;
//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

////Do while
//int t = 0;
//do
//{
//    Console.WriteLine(t);
//    t++;
//    //t = 0;
//}
//while (t < 5);


////----------------------------------------------------------------------------------
////For Loop
//for (int j = 0; j < 5; j++)
//{
//    Console.WriteLine(j);
//}


//for (int k = 0; k <= 10; k = k + 2)
//{
//    Console.WriteLine(k);
//}

//for (int r = 0; r <= 10;)
//{
//    Console.WriteLine(r);
//}
//for (; ; )
//{
//    Console.WriteLine("??");
//}

//for (int c = 0; c < 10; c++)
//{
//    if (c == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(c);
//}


//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//foreach (string item in cars)
//{
//    Console.WriteLine(item);
//}



////1.StringBulder
//// StringBuilder sb = new StringBuilder();

////or

//// StringBuilder sb = new StringBuilder("its a stringbuilder");
//// StringBuilder stringBuilder = new StringBuilder();

//var sb = new StringBuilder("Название: ");
//Console.WriteLine(sb);   // Название: 
//Console.WriteLine($"Длина: {sb.Length}"); // 10
//Console.WriteLine($"Емкость: {sb.Capacity}"); // 16

//sb.Append(" Руководство");
//Console.WriteLine(sb);   // Название: Руководство
//Console.WriteLine($"Длина: {sb.Length}"); // 22
//Console.WriteLine($"Емкость: {sb.Capacity}"); // 32

//sb.Append(" по C#");
//Console.WriteLine(sb);   // Название: Руководство по C#
//Console.WriteLine($"Длина: {sb.Length}"); // 28
//Console.WriteLine($"Емкость: {sb.Capacity}"); // 32


//var sb = new StringBuilder("Hello: ");
//StringBuilder sbb = new StringBuilder("World!");
//string aaaa = sbb.ToString();
//for (int intt = 0; intt < sb.Length; intt++)
//    Console.Write(sb[intt]); // output: Hello World!



////string +

string aaa = "aaa";
//Console.WriteLine(aaa.GetHashCode());
//Console.WriteLine(aaa.GetType());
//StringBuilder sb = new StringBuilder("Hello");
//sb.Append("fff");
aaa = "";
int m = 0;
int k = 1;
int j = k;
for (int i = 1; i <= 10; i++)
{
    m = j * i;
    Console.WriteLine(j.ToString() + "*" + i.ToString() + "=" + m.ToString());
    if (i == 10)
    {
        i = 0;
        k = k + 1;
        j = k;
    }
    if (k == 10)
        break;
}