void program()
{
    Console.WriteLine("Hei, trykk '1' hvis du vil reverse teksten eller '2' for å bytte e'er til a");
    var inputs = Console.ReadLine();

    if (inputs == "\r\n1")
    {
        reverse();
    }
    else if (inputs == "\r\n2")
    {
        string text = Console.ReadLine();
        string replaced = Replace(text, 'e', 'a');
        Console.WriteLine(replaced);
    }
    else
    {
        Console.WriteLine("Trykk '1' eller '2'!");
        program();
    }
}
program();
void reverse()
{
    string text = Console.ReadLine();

    string reversedText = "\r\n";

    for (int i = text.Length - 1; i >= 0; i--)
    {
        reversedText += text[i];
    }

    Console.WriteLine(reversedText);

}

static string Replace(string text, char from, char to)
{
    string replaced = "";
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == from) replaced += to;
        else replaced += text[i];
    }
    return replaced;
}

//void change()
//{
//    string text = Console.ReadLine();
//    string changeText = text.Replace('e', 'a');

//    Console.WriteLine(changeText);
//}

//Console.WriteLine(Replace(Console.ReadLine(),'e', 'a'));