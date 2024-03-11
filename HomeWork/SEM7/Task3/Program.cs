// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void ReverseArray (int [] array, int index){
	if(index >= 0){
		Console.Write($"{array[index]} ");
		ReverseArray(array, index -1);
	}
}

int[] array = {1,4,6,1,346,7};
ReverseArray(array, array.Length -1);
