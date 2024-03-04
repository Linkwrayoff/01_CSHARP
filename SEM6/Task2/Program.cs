// Задайте массив символов (тип char []). Создайте строку из символов этого массива. 
// Указание
// Конструктор строки вида string(char []) не использовать.
Console.Clear();
char[] arr = { '1', '2', '3', '4', '5' };
string str = "";

for (int i = 0; i < arr.Length; i++)
{
	str += arr[i];
}

Console.WriteLine(str);
