
// Пузырьковая сортировка

int n = 5;
int [] array = new int[n];

for (int i = 0; i < n; i++)
{
	array[i] = new Random().Next(15);
}
Console.WriteLine($"[{String.Join(',' , array)}]");
for(int j = 0; j < n -1 ; j++){
	for (int i = 0; i < n-1 - j; i++)
	{
		if (array[i] > array[i + 1])
		{
			int temp = array[i];
			array[i] = array[i +1];
			array[i+1] = temp;
		}
	}
}
Console.WriteLine($"[{String.Join(',' , array)}]");
