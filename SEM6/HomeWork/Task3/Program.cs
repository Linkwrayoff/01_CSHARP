// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

string str = "шалаш";
string str2 = "Да";
for(int i = 0; i< str.Length / 2; i++){
	if(str[i] != str[str.Length - 1 - i]){
		str2 = "Нет";
	}
}
Console.Write(str2);
