string[] full = new string[4];
Console.WriteLine("Введите строки");
string s = FillArray(full);
string[] cut = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
AddArray(full);
AddArray(cut);
Console.WriteLine();
Console.Write("[" + string.Join(", ", full) + "] -> ");
Console.Write("[" + string.Join(", ", cut) + "]");

string FillArray(string[] data)
{
    string row = string.Empty;
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write($"Строка {i + 1}: ");
        data[i] = Console.ReadLine() + "";
        TestRow(data, i);
        if (data[i].Length <= 3)
        {
            row += " " + data[i];
        }
    }
    return row;
}
void AddArray(string[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = "\"" + data[i] + "\"";
    }
}
void TestRow(string[] data, int i)
{
    while (data[i] == "")
    {
        Console.WriteLine($"Строка пустая, введите строку {i + 1} заново");
        Console.Write($"Строка {i + 1}: ");
        data[i] = Console.ReadLine() + "";
    }
}