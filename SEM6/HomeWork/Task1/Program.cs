//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
Console.Clear();

char[,] multiArr = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };

string[,] str = "";

for (int i = 0; i < multiArr.GetLength(0); i++)
{
	for (int j = 0; j < multiArr.GetLength(1); i++)
	{
		str[i] += multiArr[i, j];
	}
}

Console.WriteLine(str);
