Console.WriteLine("Введите текст: ");
string text1 = Console.ReadLine();
string text2 = "";
for (int i = 0; i < text1.Length; i++)
{
    if (text1[i] == '.')
    {
        text2 += "..";
    }
    else
    {
        text2 += text1[i];
    }
}
Console.WriteLine(text2);
