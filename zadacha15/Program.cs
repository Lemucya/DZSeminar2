/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/
Console.WriteLine("Введите цифру, обозначающую день недели, от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string[] dayWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (dayNumber == 6 ^ dayNumber == 7)
{
    Console.WriteLine($"{dayWeek[dayNumber -1]} выходной день");
}
else if (dayNumber > 0 && dayNumber < 6)
{
    Console.WriteLine($"{dayWeek[dayNumber -1]} будний день");
}
else
Console.WriteLine("Ошибка ввода!!! Введите цифру от 1 до 7");