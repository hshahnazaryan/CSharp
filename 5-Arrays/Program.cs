using System;
using System.Text;

char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

/// <summary>
/// 
/// </summary>

char[] myArray1 = { 'H', 'e', 'l', 'l', 'o' };

foreach (char ch in myArray1)
{
    Console.WriteLine(ch);
}

/// <summary>
/// 
/// </summary>

char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
int male = 0, female = 0;
foreach (char g in gender)
{
    if (g == 'm')
        male++;
    else if (g == 'f')
        female++;
}
Console.WriteLine("Number of male = {0}", male);
Console.WriteLine("Number of female = {0}", female);
/// <summary>
/// ///////
/// </summary>

var numbers = new List<int>() { 5, -8, 3, 14, 9, 17, 0, 4 };
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("Sum = {0}", sum);
Console.ReadLine();


/// <summary>
/// 
/// </summary>

// объявить массив типа double, выделить память для массива
double[] A = new double[10];
Random rnd_num = new Random();

// заполнить массив случайными числами в диапазоне от 0 до 20
for (int i = 0; i < A.Length; i++)
{
    A[i] = rnd_num.NextDouble() * 20;
}

// вывести массив для проверки
Console.WriteLine("Array A:");
for (int i = 0; i < A.Length; i++)
{
    Console.Write("{0:f3} ", A[i]);
}
Console.WriteLine();

// Использование цикла foreach для вычисления суммы элементов массива
double summ = 0;
foreach (double item in A)
{
    summ += item;
}

Console.WriteLine("summ = {0:f3}", summ);
Console.ReadKey();

//int a = 9;
//Int16 b = 10;
//Int32 c = 11;
//Int64 d = 12;

//Console.WriteLine(a.GetType());
//Console.WriteLine(b.GetType());
//Console.WriteLine(c.GetType());
//Console.WriteLine(d.GetType());

StringBuilder a = new StringBuilder("a");
Console.WriteLine(a.ToString());


////reverse foreach
///
string[] cars = new string[4] { "Volvo", "BmW", "Opel", "Nissan" };
int cc = cars.GetLength(0);


Console.WriteLine(cars[4]);