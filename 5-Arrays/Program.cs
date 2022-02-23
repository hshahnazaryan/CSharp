char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}


char[] myArray1 = { 'H', 'e', 'l', 'l', 'o' };

foreach (char ch in myArray1)
{
    Console.WriteLine(ch);
}


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


var numbers = new List<int>() { 5, -8, 3, 14, 9, 17, 0, 4 };
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("Sum = {0}", sum);
Console.ReadLine();