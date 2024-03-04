// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string input_string = "Существют две основные трактовки понтия текст";
string result = "";
string [] temp_array = input_string.Split(" ");
for(int i = temp_array.Length  -1; i >= 0; i--){
	result += temp_array[i];
	result += " ";
}
Console.WriteLine(result);
