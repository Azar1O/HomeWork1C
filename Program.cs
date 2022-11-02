// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > secondNumber)
{
    Console.WriteLine(FirstNumber + " > " + secondNumber);
}
else if (secondNumber > FirstNumber)
{
    Console.WriteLine(secondNumber + " > " + FirstNumber);
}
else
{
     Console.WriteLine(secondNumber + " = " + FirstNumber);
}