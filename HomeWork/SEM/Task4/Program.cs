// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
int n = 1234;
string nNew = n.ToString();
int i = 0;

while (i < nNew.Length - 1)
{
	Console.Write(nNew[i] + ", ");
	i++;
}
Console.Write(nNew[i]);
