// Функции по заполнению, вычислению суммы и произведений чисел в массиве
int n = 10;
int[] arr = new int[n];

void FillArray(int[] arr)
{
	int i = 0;
	while (i < n)
	{
		arr[i] = i++;
	}
}

void PrintArray(int[] arr)
{
	foreach (int e in arr)
	{
		Console.WriteLine($"{e} ");
	}
}

int GetSumOfElements(int[] arr){
	int i = 0;
	int sum = 0;
	
	while(i < n){
		sum = sum + arr[i];
		i++;
	}
	return sum;
}

int GetProductOfElements(int[] arr){
	int i = 1;
	int product = 1;

	while(i < n){
		product = product * arr[i];
		i++;
	}
	return product;
}

FillArray(arr);
PrintArray(arr);
int sumResult = GetSumOfElements(arr);
int productResult = GetProductOfElements(arr);
Console.WriteLine(sumResult);
Console.WriteLine(productResult);
