﻿// Сумма чисел через рекурсию

int SumOfDigits(int num){
	if(num == 0){
		return 0;
	}
	int sum = num % 10 + SumOfDigits(num/10);
	return sum;
}

int num = 1007;
int result = SumOfDigits(num);
Console.Write(result);

/* --------------------------------------------------- */

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// 	Указание =>
// 		Использовать рекурсию. Не использовать цикл.
// 		Пример
// N=5 => 1 2 3 4 5

void GetIntegersOfNum (int N){
	if(N == 0){
		return;
	}
	GetIntegersOfNum(N - 1);
	Console.Write(N +" ");
}

GetIntegersOfNum(5);
