string ReplaceSymbol(string text, char oldSym, char newSym)
{
    string result = String.Empty;      // создает новую пустую строку
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldSym) result += $"{newSym}";
        else result += $"{text[i]}";
    }
    return result;
}


string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

Console.WriteLine(text);
Console.WriteLine();

string newText = ReplaceSymbol(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = ReplaceSymbol(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = ReplaceSymbol(text, 'с', '$');
Console.WriteLine(newText);
