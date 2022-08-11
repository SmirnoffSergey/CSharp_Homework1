// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
 Console.WriteLine("Введите два числа");
 Console.Write("number1 = ");
 double number1 = Convert.ToDouble(Console.ReadLine());
 Console.Write("number2 = ");
 double number2 = Convert.ToDouble(Console.ReadLine());

 if (number1 > number2)
     {
     //  Console.WriteLine($"{number1} > {number2}");
     Console.WriteLine("Большее число " + number1 + ", а меньшее число " + number2);
     }
 else
     {
         if (number1 == number2)
         {
         Console.WriteLine("Число " + number1 + " = " + number2);
         }
         else 
         {
         Console.WriteLine("Большее число " + number2 + ", а меньшее число " + number1);
         }
     }   
*/


// Задача 4: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите три числа");
Console.Write("number1 = ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("number2 = ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("number3 = ");
double number3 = Convert.ToDouble(Console.ReadLine());
double max = number1;

if(number2 > max)
    {
        max = number2;
    }
else
    {
        if(number3 > max)
        {
        max = number3;
        }

    }
Console.Write("Максимальное из этих чисел равно ");
Console.WriteLine(max);
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число");
Console.Write("number = ");

int number = Convert.ToInt32(Console.ReadLine());
if (number %2 == 0)
    {
    Console.Write("Число " + number + " чётное");
    }
else
    {
    Console.Write("Число " + number + " НЕчётное"); 
    }   
*/


// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число, для того,чтобы отобразились все чётные числа до него вкдючительно");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= N)
{
    Console.Write(current + "  ");  
    current+=2;
}