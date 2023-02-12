// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine("Большее число: ");
    Console.WriteLine(numberA);

    Console.WriteLine("Меньшее число: ");
    Console.WriteLine(numberB);

}

else if(numberA < numberB)
{
    Console.WriteLine("Большее число: ");
    Console.WriteLine(numberB);

    Console.WriteLine("Меньшее число: ");
    Console.WriteLine(numberA);
}

else
{
    Console.WriteLine("Числа ровны!");
}