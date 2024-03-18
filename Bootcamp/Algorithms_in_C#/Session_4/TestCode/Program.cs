// Сортировка выбором

void CreateArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(-20, 21);
}

int[] SortArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		int iMin = i;
		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] < array[iMin])
				iMin = j;
		}
		if (iMin == array[i])
			continue;

		int temp = array[i];
		array[i] = array[iMin];
		array[iMin] = temp;
	}
	return array;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine()!);
int [] arr = new int [num];
CreateArray(arr);
Console.WriteLine($"Начальный массив: [{string.Join(", ", arr)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", SortArray(arr))}]");
