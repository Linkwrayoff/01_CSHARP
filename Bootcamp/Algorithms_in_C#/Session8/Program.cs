

// -------------- Фибоначчи --------------//
/*
int fib(int n){
	if(n == 0 || n == 1){
		return n;
	}
	return fib(n-1) + fib(n - 2);
}

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число Фибоначчи: {fib(n)}");
*/

// -------------- Сумма --------------//
/*
int Sum(int a, int b){
	if(b == 0){
		return a;
	}
	return Sum(a + 1, b - 1);
}

Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Sum(n, m);
Console.WriteLine($"{n} + {m} = {Sum(n, m)}");
*/

// -------------- Алгоритм быстрой сортировки --------------//

int quickSort(int [] array){
	if( array.Length < 2){
		return array;
	}else{
		int pivot = array[0];
		int count = 0;
	}
}






Console.Clear();
int [] array = {7, 5, 2, 5, 7, 8, 3};
Console.WriteLine($"Начальный массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{String.Join(", ", quickSort(array))}]");
