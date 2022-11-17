//Задача 2
//Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
/*Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());
if (num_A > num_B)
Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A); 
*/
//a = 5, b = 7 -> max = 7
//a = 2, b = 10 -> max = 10
//a = -9, b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
}
else
{
Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
}


// Задача 4
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
/*Console.WriteLine("Введите 3 числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());
int max = num_1;
if (num_2 > max)
Console.WriteLine("Наибольшее из введённых чисел -> " + max);
*/
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

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


// Задача 6
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 1)
Console.WriteLine("Число " + num + " является: нечётным");
Console.WriteLine("Число " + num + "является: чётным");
*/
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: нечётным");
}
else
{
    Console.WriteLine("Число " + num + "является: чётным");
}


// Задача 8
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*int i = 1;
bool not = true;
Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
if (i % 2 != 1)
Console.Write(i + ", ");
not = false;
i++;
if (not)
Console.WriteLine("Нет чётных чисел!");
*/
//5 -> 2, 4
//8 -> 2, 4, 6, 8

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
