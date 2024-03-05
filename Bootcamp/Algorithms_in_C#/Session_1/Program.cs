﻿/*
Виды Алгоритмов
1. Константные O(1) - O(2)
2. Логарифмические - Бинарный поиск 
3. Линейные - O(n) -  O(2*n)...
4. Линейно-логарифмические - быстрая сортировка 
5. Квадратные - пузырьковая сортировка, сортировка выбором, сортировка вставками и тд.
6. Кубические - трехмерные массивы
*/

// Напишите программу, которая считает сумму чисел от 1 до n.(1 и 3 тип алгоритма)
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), result = 0; // ["345"] <- 345
// int n - Convert.ToInt32(Console.ReadLine());// ["123"] -> 123 -> [123]
// for(int i = 1; i <=n; i++){ // O(n)
// 	result += i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!), result = 0; // O(1) - O(2)
Console.WriteLine($"Сумма чисел от 1 до {n} равна {(1 + n) / 2.0 * n}");


// Бинарный поиск (двоичный поиск) 2 тип алгоритма
// загаданное число - 67
// от 1 до 100
// Число больше 50? - Да (от 50 до 100)
// Число больше 75? - Нет (от 50 до 75)
// Число больше 62? - Да (от 62 до 75)
// Число больше 68? - Нет (от 62 до 68)
// Число больше 65? - Да (от 65 до 68)
// Число больше 66? - Да (от 66 до 68)
// Число больше 67? - Нет (Ответ - 67)
// 7 попыток
// Сложность алгоритма бинарного поиска  равен O(log2(n))
// log2(1000) ~ 10 попыток

// [34, 1, 2, -10, 56, 314, 13, 1, 2, 4, 90, -123]; 
// n - количество элементов массива
//O(n * log2(n)) + O(log2(n))


// Быстрая сортировка O(n * log2(n)) (Рекурсивный подход)

// [34, -10, 23, 5, 2, 1]
// 1. Выбирается опорный элемент(в основном первый элемент массива)
// 2. Создается два массива. 1 массив содержит элементы меньше опорного,
// 2-ой массив содержит элементы больше или равные опорному.


// Опорный элемент равен 34 [-10, 1, 2, 5, 23, 34]
// [-10, 23, 5, 2, 1] + [34] + []
// Опорный элемент равен -10 [-10, 1, 2, 5]
// [] + [-10] + [23, 5, 2, 1]
//Опорный элемент 23 [1, 2, 5, 23]
// [5, 2, 1] + [23] + []
// Опорный элемент равен 5 [1, 2, 5]
// [2, 1] + [5] + []
// Опорный элемент равен 2 [1, 2]
// [1] + [2] + []

