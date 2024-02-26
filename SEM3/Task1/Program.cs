// int num = 8;
// int[] arr = new int[] { 2, 4, 6, 8, 9 };
// bool flag = false;

// foreach(int item in arr){
// 	if(item == num){
// 		flag = true;
// 	}
// }
// if (flag){
// 	Console.Write("Да");
// } else{
// 	Console.Write("Нет");
// }

// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные элементы на положительные, а положительные на отрицательные.
// int[] arr = new int[] { 2, -2, 3, -4, -7, 8, 1, -10, 10, 5 };

// for(int i =0; i<=arr.Length; i++){
// 	arr[i] = arr[i] * -1;
// 	Console.Write(arr[i] + " ");
// }

// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.

// Пример

// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] arr = new int[] { 3, 4, 5, 6, 2, 5, 1, 2 };
int[] newArr = new int[arr.Length / 2];

for (int i = 0; i < arr.Length / 2; i++)
{
	newArr[i] = arr[i] * arr[arr.Length - (1 + i)];
	Console.Write(newArr[i] + " ");
}
