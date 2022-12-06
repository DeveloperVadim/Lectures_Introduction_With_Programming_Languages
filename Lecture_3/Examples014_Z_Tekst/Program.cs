//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string text = "qwerty"
//                012345
//text[3] -> r
string Replase(string text, char oldValue, char newValue) // (входной текст,изменяемый символ,измененый символ)
{
    string result = String.Empty; // заводим новую строку (String.Empty-пустая)
    int length = text.Length; // показать длину строки
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result; // возврат результата
}
string newText = Replase(text, ' ', '|');
//Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
//Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();
