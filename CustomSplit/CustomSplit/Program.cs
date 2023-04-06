string[] CustomSplit(string String, char Character)
{
    string[] array = new string[0];
    string Str = string.Empty;

    for (int j = 0; j < String.Length; j++)
    {
        if (String[j] != Character && j != String.Length - 1)
        {
            Str += String[j];
        }

        else
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = Str;
            Str = string.Empty;
        }
    }
    return array;
}

Console.WriteLine("Add a string:");
string String = Console.ReadLine();
Console.WriteLine("Add a char:");
char Character = char.Parse(Console.ReadLine());
string[] arr = CustomSplit(String, Character);

for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}