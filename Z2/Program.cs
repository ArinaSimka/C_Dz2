// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// ВАРИАНТ РЕШЕНИЯ 1

// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// int n = int.Parse(num);
// if (n < 100)
// {     Console.WriteLine("Третьей цифры нет"); }
// else if (n >= 100 && n <= 999) // если 3-значное
// {     int rez3 = n % 10;
//     Console.WriteLine($"Третья цифра числа: {rez3}");}
// else if (n >= 1000 && n <= 9999) // если 4-значное
// {    int rez4 = (n % 100) /  10;
//     Console.WriteLine($"Третья цифра числа: {rez4}");}
// else if (n >= 10000 && n <= 99999) // если 5-значное
// {    int rez5 = (n % 1000) /  100;
//     Console.WriteLine($"Третья цифра числа: {rez5}");}
// else if (n >= 100000 && n <= 999999) // если 6-значное
// {    int rez6 = (n % 10000) /  1000;
//     Console.WriteLine($"Третья цифра числа: {rez6}");}
// else 
// {    Console.WriteLine("Превышено кол-во символов");}

// ВАРИАНТ РЕШЕНИЯ 2

Console.Write("Введите число: ");
string num = Console.ReadLine();
int n = int.Parse(num);
char [] array = num.ToCharArray();

if (n > 99)
 {
    Console.WriteLine($"Третья цифра: {array[2]}");
    }
else
{
    Console.WriteLine("Третьей цифры нет");
}
