 // Задача 3: 
 // Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
 
 void Main(){
	int [] arr = {1, 2, 3, 4, 5, 6};
	int temp;

	Console.Write("Исходный массив: ");
	foreach(int number in arr){
		Console.Write(number + " ");
	}
	for(int i = 0; i < arr.Length / 2; i++){
		temp = arr[i];
		arr[i] = arr[arr.Length -1 - i];
		arr[arr.Length -1 - i] = temp;
	}
	Console.Write("\nПеревернутый массив: ");
	foreach (int number in arr)
	{
		Console.Write(number + " ");
	}

}
Main();
