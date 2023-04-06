Console.WriteLine("Enter a string:");
string String = Console.ReadLine();
string Result = CustomReverse(String);
Console.WriteLine(Result);

string CustomReverse(string String)
{
    Result = string.Empty;
    for(int i = String.Length - 1; i >= 0; i--)
    {
        Result += String[i];
    }
    return Result;
}
