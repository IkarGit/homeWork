﻿// Задача №1
Console.Clear();
Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine("{0} наибольшее число",a);

}
else
{
   Console.WriteLine("{0} наибольшее число",b); 
}

Console.ReadLine();