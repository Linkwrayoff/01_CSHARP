// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

string str = "asfasf";
void IsPalindrom(string str){
	for(int i = 0; i< (str.Length / 2); i++){
		if(str[i] != str[i -1]){
			Console.Write("Не палиндром");
		}else{
			Console.Write("Палиндром");
		}
	}
}
IsPalindrom("asfasf");
Console.Write(IsPalindrom("asfasf"));
