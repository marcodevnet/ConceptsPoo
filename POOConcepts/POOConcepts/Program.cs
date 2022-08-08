using POOConcepts;

Console.WriteLine("Conceptos de POO!");
Console.WriteLine("==============");
try
{
    Console.WriteLine(new Date(2024, 29, 2));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 09, 45));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}

