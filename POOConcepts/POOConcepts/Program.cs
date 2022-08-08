using POOConcepts;

Console.WriteLine("Conceptos de POO!");
Console.WriteLine("==============");
try
{
    Console.WriteLine(new Date(2022, 12, 7));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 18, 45));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}

