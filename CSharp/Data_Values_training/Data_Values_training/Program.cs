// decimal.TryParse(myInput, out myInputDecimal);
string newValue = "";
string[] value = { "12,3", "45", "12", "KAPPAS", "DEF" };
decimal result = 0;
decimal newDecimal = 0;
for (int i = 0; i < value.Length; i++)
{
    if (decimal.TryParse(value[i], out result))
    {
        newDecimal += result;
        Console.WriteLine($"Measurement: {newDecimal}");
    }
    else
    {
        Console.WriteLine($"Unable to report the measurement");
            newValue += value[i];
        Console.WriteLine(newValue);
    }

}
