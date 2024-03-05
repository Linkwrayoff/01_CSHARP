//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
Console.Clear();

char[,] multiArr = new char [,]
{ 
	{ 'a', 'b', 'c' },
	{ 'd', 'e', 'f' } 
	};

string str = "";

for (int i = 0; i < multiArr.GetLength(0); i++)
{
	for (int j = 0; j < multiArr.GetLength(1); j++)
	{
		str += multiArr[i, j];
	}
}

Console.WriteLine(str);
