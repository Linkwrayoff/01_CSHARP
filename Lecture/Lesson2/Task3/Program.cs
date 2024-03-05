int N = 10;
int[] arr = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
int i = 0;

while (i < N)
{
	if (arr[i] % 2 == 1){
		Console.Write($"{arr[i]} ");
	}
	i++;
}
