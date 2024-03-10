// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример

// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void GetConsonants (string str){
	if(str.Length == 0){
		return;
	}

	string vovels = "aeoyiu";
	if (char.IsAsciiLetter(str[0]) && !vovels.Contains(char.ToLower(str[0]))){
		Console.Write($"{str[0]} ");
	}
	GetConsonants(str.Substring(1));
}

GetConsonants("asfa3f3");
