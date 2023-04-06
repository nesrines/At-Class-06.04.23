Console.WriteLine("Add a string:");
string String = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Add a char:");
char Char = char.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(CustomContains(String, Char));

bool CustomContains(string String, char Char)
{
    bool Contains = false;
    for (int i = 0; i < String.Length; i++)
    {
        if (Char == String[i])
        {
            Contains = true;
            break;
        }
    }
    return Contains;
}