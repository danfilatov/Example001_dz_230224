//Task 2; Программа, которая на вход принимает 2 числа и выдает какое число больше а какое меньше
Console.WriteLine("Task 2; Программа, которая на вход принимает 2 числа и выдает какое число больше а какое меньше");
Console.Write("Введите первое число: "); 
int numA = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: "); 
int numB = Convert.ToInt32 (Console.ReadLine());

if (numA > numB)
{
     Console.WriteLine($"Первое число: {numA}, больше чем второе число: {numB}");
}

else
{
     Console.WriteLine($"Второе число: {numB}, больше чем первое число: {numA}");
}