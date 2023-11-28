
void reverse()
{
    string text = Console.ReadLine();

    string reversedText = "";

    for (int i = text.Length - 1; i >= 0; i--)
    {
        reversedText += text[i];
    }

    Console.WriteLine(reversedText);

}
reverse();

//void change()
//{
//    string text = Console.ReadLine();
//    string changeText = text.Replace('e', 'a');

//    Console.WriteLine(changeText);
//}
//change();

//Console.WriteLine(Replace(Console.ReadLine(),'e', 'a'));

string text = Console.ReadLine();
string replaced = Replace(text, 'e', 'a');
Console.WriteLine(replaced);
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