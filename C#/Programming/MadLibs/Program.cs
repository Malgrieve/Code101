// ======================================================================== C# MADLIBS =======================================================================
// ======================================================================= KODA SYSTEMS ======================================================================


string color, pnoun, person;

Console.Write("Enter a color > ");
color = Console.ReadLine(); // Get color

Console.Write("Enter a plural noun > ");
pnoun = Console.ReadLine(); // Get plural noun

Console.Write("Enter a someone's name > ");
person = Console.ReadLine(); // Get person

Console.WriteLine("");
Console.WriteLine("Haiku:");
Console.WriteLine("");
Console.WriteLine("   Roses are " + color);
Console.WriteLine("   " + pnoun + " are blue");
Console.WriteLine("   I Love " + person);

Console.ReadLine();