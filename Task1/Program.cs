// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

Console.Write("Please, input numbers (separated by a space):  ");
int[] numbersArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < numbersArray.Length; i++)
{
    if (numbersArray[i] > 0) count++;
}

Console.WriteLine($"Count numbers > 0: {count}");