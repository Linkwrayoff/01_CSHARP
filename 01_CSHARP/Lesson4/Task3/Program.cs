// string GetLetters(string s)
// {
// 	string letters = "";
// 	foreach (char e in s)
// 	{
// 		if (char.IsAsciiLetter(e) == true)
// 		{
// 			letters += e;
// 		}
// 	}
// 	return letters;
// }

// Console.WriteLine("Введите символы: ");
// string str = Console.ReadLine();
// string result = GetLetters(str);
// Console.WriteLine(result);


int[] GetNumbers(string n){
	string symbols = "";
	foreach(char e in n){
		
		if(int.TryParse(char.ToString(e), out int nums) == true){
			symbols += e;
		}
	}

	int[] arr = new int [symbols.Length];
	for(int i = 0; i < symbols.Length; i++){
		int.TryParse(char.ToString(symbols[i]), out arr[i]);
	}
	return arr;
}

Console.WriteLine("Введите символы: ");
string str = Console.ReadLine();
int [] resultNums = GetNumbers(str);
Console.WriteLine(string.Join(",", resultNums));
