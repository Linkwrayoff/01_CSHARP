// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
string test = "Hello";
string test2 = test.toUpperCase;


char [] str = new char [test.Length];
for(int i = 0; i < test.Length; i++){
	str[i] = test[i];
}

foreach(char item in str){
	Console.Write(item);
}
