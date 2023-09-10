// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// ВАРИАНТ РЕШЕНИЯ 1

// Console.Write("Введите число: ");
// string strNum = Console.ReadLine();
// int weekDay = int.Parse(strNum);

// if(weekDay==1) {Console.WriteLine("Понедельник");}
// else if(weekDay==2) {Console.WriteLine("Вторник");}
// else if(weekDay==3) {Console.WriteLine("Среда");}
// else if(weekDay==4) {Console.WriteLine("Четверг");}
// else if(weekDay==5) {Console.WriteLine("Пятница");}
// else if(weekDay==6) {Console.WriteLine("Суббота");}
// else if(weekDay==7) {Console.WriteLine("Воскресенье");}
// else  {Console.WriteLine("неправильная дата");
// return;}
// if(weekDay==6 || weekDay==7) {Console.WriteLine("Выходной");}
// else {Console.WriteLine("Рабочий день");}


// ВАРИАНТ РЕШЕНИЯ 2

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int weekDay = int.Parse(strNum);
string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (weekDay > 7 || weekDay < 1 )
{
    Console.WriteLine("неправильная дата");
}
else 
{
    Console.WriteLine($"День недели: {array[weekDay-1]}");
    if(weekDay==6 || weekDay==7) 
    {   
         Console.WriteLine("Выходной");
    }
    else 
    {
        Console.WriteLine("Рабочий день");
    }
}