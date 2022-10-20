// является ли число четным

/*
Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int OST = num % 2;
if (OST==0)
{
    Console.WriteLine($"число {num} является  четным");
}

else
Console.WriteLine($"число {num}  не является  четным");
*/


/*
// Определение большего и меньшего числа3

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число");
int num2 = Convert.ToInt32(Console.ReadLine());
 if (num1 > num2)
 {
     Console.WriteLine($"число {num1} больше {num2}");
 }

 else 
 {
     Console.WriteLine($"число {num2} больше {num1}");
 }
 
 */



 // задание сформулировано криво. В тексте "выдает какое больше, а какое меньше". В примере - выводится только максимальное!
 // второй вариант


 /*

 Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число");
int num2 = Convert.ToInt32(Console.ReadLine());
 if (num1 > num2)
 {
     Console.WriteLine($" Максимальное число число {num1}");
 }

 else 
 {
     Console.WriteLine($" Максимальное число {num2} ");
 }
 */


/*
 //Максимальное из трех чисел

 Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
 {
    if (num1 > num3)

    {
     Console.WriteLine($"Максимальное число {num1}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {num3}");
    }
 }
 else if (num2 > num3)
 {
    Console.WriteLine($"Максимальное число {num2} ");

 }
 else
 {
    Console.WriteLine($"Максимальное число {num3} ");
 }
 */

// все четные числа в диапазоне 1 - N

Console.WriteLine("Введите длинну ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (num==1)
{
   Console.WriteLine("Чётных чисел нет "); 
}

else
{
Console.WriteLine($"четные числа от 1 до {num}: "); 

while (i <= num)
{
    Console.Write(i); 
    i= i+2;
}
}



