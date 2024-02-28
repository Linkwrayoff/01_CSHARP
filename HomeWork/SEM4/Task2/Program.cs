// Задача 2:
// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateRandomArray(int min, int max, int size){
	int [] arr	= new int[size];
	for(int i = 0; i < size; i++){
		arr[i] = new Random().Next(min, max + 1);
	}
	return arr;
}

void GetCountOfEven(int[] arr){
	int count = 0;
	foreach(int item in arr){
		Console.Write(item + " ");
		if(item % 2 == 0){
			count += 1;
		}
	}
	Console.WriteLine(" ");
	Console.WriteLine(count);
}

int[] consoleArr = CreateRandomArray(100, 999, 10);
GetCountOfEven(consoleArr);
