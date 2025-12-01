Console.WriteLine("Skriv inn første tallet: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Skriv inn andre tallet: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Skriv in matte symbol (+, -, *, /): ");
char MathSymbol = Convert.ToChar(Console.ReadLine());
if (MathSymbol == '+')
{
    Console.WriteLine($"Resultatet er: {num1 + num2}");
}
else if (MathSymbol == '-')
{
    Console.WriteLine($"Resultatet er: {num1 - num2}");
}
else if (MathSymbol == '*')
{
    Console.WriteLine($"Resultatet er: {num1 * num2}");
}
else if (MathSymbol == '/')
{
    if (num2 != 0)
    {
        Console.WriteLine($"Resultatet er: {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Feil: Kan ikke dele med null.");
    }
}
else
{
    Console.WriteLine("Ugyldig matematisk symbol.");
}
