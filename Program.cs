case 1:
// Задача №1
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

case 2:
            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

            Console.WriteLine("Введите 3 числа:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int num_3 = Convert.ToInt32(Console.ReadLine());

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Наибольшее из введённых чисел -> " + max);
            break;

        case 3:
            // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
            }
            break;

        case 4:
            // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

            int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
            break;

        default:
            begin = false;
            break;
    }
}