int number = new Random().Next(0, 999);
System.Console.WriteLine(number);

int result = 0;

if (number > 99)
{
    result = (number % 10);
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}

