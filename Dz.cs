Console.OutputEncoding = System.Text.Encoding.UTF8;
// задача 1

Console.Write("Введіть число від 1 до 100: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <= 100)
    if (n % 3 == 0 && n % 5 == 0)
        Console.WriteLine("Fizz Buzz");
    else if (n % 3 == 0)
        Console.WriteLine("Fizz");
    else if (n % 5 == 0)
        Console.WriteLine("Buzz");
    else
        Console.WriteLine(n);
else
    Console.WriteLine("Помилка: неприпустиме значення");

// задача 2

Console.Write("Введіть основне число: ");
double n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть відсоток: ");
double n2 = Convert.ToInt32(Console.ReadLine());
double res = (n2 / 100) * n1;
Console.WriteLine(res);

// задача 3

Console.Write("Введіть перше число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть друге число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть треттє число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть четверте число: ");
int n4 = Convert.ToInt32(Console.ReadLine());
int res = (n1 * 1000) + (n2 * 100) + (n3 * 10) + n4;
Console.WriteLine(res);

// задача 4
Console.Write("Введіть шестизначне число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 100000 && n <= 999999)
{
    int n1 = n / 100000;
    int n2 = (n / 10000) % 10;
    int n3 = (n / 1000) % 10;
    int n4 = (n / 100) % 10;
    int n5 = (n / 10) % 10;
    int n6 = n % 10;
    Console.WriteLine($"{n6}{n2}{n3}{n4}{n5}{n1}");
}
else
{
    Console.WriteLine("Ви ввели не 6-значне число");
}
