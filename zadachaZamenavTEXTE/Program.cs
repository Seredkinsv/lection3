// ====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с". Ясна ли задача?

string text = "- Я думаю, — сказал князь улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//номер символ 0123
// чтобы получить нужный символ ставим идентификатор строки и номер символа s[3] // будет r  

string Replace(string text, char oldValue, char newValue)
{
   // делаем инициализацию пустой строки  String.Empty
    string result = String.Empty;
// делаем обращение к свойству показавающее кол-во символов в строке
int length =  text.Length;
// используя цикл for - пробегаем от нулевого символа до конца строки 
for (int i = 0; i < length; i++)
{ 
    if(text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
}
    return result;

}
String newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);