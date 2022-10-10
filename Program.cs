Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number >7) 
Console.WriteLine($"{number} Число не верно - в неделе 7 дней.");
if (number <1)
Console.WriteLine($"{number} Число не верно - в неделе 7 дней.");

else if (number == 1) Console.WriteLine("Понедельник - рабочий день.");
else if (number == 2) Console.WriteLine("Вторник - рабочий день.");
else if (number == 3) Console.WriteLine("Среда - рабочий день.");
else if (number == 4) Console.WriteLine("Четверг - рабочий день.");
else if (number == 5) Console.WriteLine("Пятница - рабочий день.");
else if (number == 6) Console.WriteLine("Суббота - выходной день.");
else if (number == 7) Console.WriteLine("Воскресенье - выходной день.");