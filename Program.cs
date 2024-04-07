// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

int ShowNumbersBetween(int num1, int num2) {
    if(num1 > num2) {return 0;}
    Console.Write($"{num1} ");
    int res = ShowNumbersBetween((num1 + 1), num2);
    return res;
}

Console.WriteLine("Введите 2 числа ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbersBetween(M,N);