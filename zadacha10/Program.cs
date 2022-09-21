/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/
Console.WriteLine("Введите трехзначное число: ");
int number=Convert.ToInt32(Console.ReadLine());

int getNumberTwoisTree(int number)
{
int result = new int();
result = number % 100;
result /= 10;
return result;
}

if(number > 99 & number <1000)
{
    int number2 = getNumberTwoisTree(number);
    Console.WriteLine(number2);
}