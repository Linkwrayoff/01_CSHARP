// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
using System;

static void Main()
{
	int number;
	string input;
	int sum = 0;

	while (true)
	{
		Console.WriteLine("Введите число или 'q' для выхода");
		input = Console.ReadLine();

		if (input == "q")
		{
			break;
		}

		if (int.TryParse(input, out number))
		{
			for (int i = 0; i < input.Length; i++)
			{
				sum += Convert.ToInt32(input[i]);
			}

		if (sum % 2 == 0)
		{
			break;
		}
			sum = 0;
		}
	}
	Console.WriteLine("Вы вышли из программы");
	return;
}
Main();
