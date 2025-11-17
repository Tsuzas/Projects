
string[] fradulent = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
string string2Check = "B";

foreach (var nameFrad in fradulent)
{
    if (nameFrad.Contains(string2Check))
    {
        Console.WriteLine($"Found the substring {string2Check} in {nameFrad}");
    }
}