//Программа которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
//Программа которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
    Console.WriteLine("Введите число:");
    
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();

Console.WriteLine(numberS.Length > 2 ? $"{number} -> {numberS[2]}" : $"{numberS} -> третьей цифры нет");
    
// Программа которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, являеться ли этот день выходным     

Console.WriteLine("Введите цифру, обозначающую день недели:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
string isWeekend = (dayOfWeek > 0 && dayOfWeek < 8) 
    ? (dayOfWeek == 6 || dayOfWeek == 7) ? "да" : "нет"
    : "не день недели";

Console.WriteLine($"{dayOfWeek} -> {isWeekend}");