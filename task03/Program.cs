
//             0 1 2 3 4 5 6 7
int [] days = {1,2,3,4,5,6,7};



Console.Write("Введите  номер дня недели:");
int number = Int32.Parse(Console.ReadLine());
//Console.WriteLine(number);

if(days[number-1] > days[4])
{
    System.Console.WriteLine("Выходной");
}
else
{
    System.Console.WriteLine("Будни");
} 
