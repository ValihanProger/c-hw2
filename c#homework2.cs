// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <=999)
{
    Console.WriteLine($"{number} -> {number%10}");
}
else if (number >=1000 && number <= 9999) 
{
    Console.WriteLine($"{number} -> {(number/10)%10}");
}
else if (number >= 10000 && number <= 99999)
{
    Console.WriteLine($"{number} -> {(number/100)%10}");
}
else if (number >= 100000 && number <= 999999)
{
    Console.WriteLine($"{number} -> {(number/1000)%10}");
}
else if (number >= 1000000 && number <= 9999999)
{
    Console.WriteLine("Вызывайте Сеньера я не знаю как дальше, чтобы автоматически это делало полюбому как-то можно");
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}