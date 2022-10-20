// является ли число четным

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int OST = num % 2;
if (OST==0)
{
    Console.WriteLine($"число {num} является  четным");
}

else
Console.WriteLine($"число {num}  не является  четным");