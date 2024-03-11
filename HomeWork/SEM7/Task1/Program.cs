//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void GetIntegersOfNum(int M, int N){
	if(N < M){
		return;
	}
	Console.Write($"{M} ");
	GetIntegersOfNum(M + 1, N);
}
GetIntegersOfNum(4, 17);
