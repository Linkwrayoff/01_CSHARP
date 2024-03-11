// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann (int m, int n){
	if(m == 0){
		return n + 1;
	} else if(m > 0 && n == 0){
		return Ackermann(m-1, 1);
	} else if(m > 0 && n > 0){
		return Ackermann(m -1, Ackermann(m, n -1));
	}
	return -1;
}
Console.Write(Ackermann(2, 1));
