//3.29.Дано натуральное число n (n > 9). Найти:
//а)  число единиц в  нем;
//б)  число десятков в  нем

Console.WriteLine("введите натуральное n:");
int n = int.Parse(Console.ReadLine());
int e = n % 10;
int d = (n / 10) % 10;
Console.WriteLine($"число едениц: {e}");
Console.WriteLine($"число десятков: {d}");
