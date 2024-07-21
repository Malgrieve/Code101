// ==================================================================== C# BASIC EDUCATION ===================================================================
// ======================================================================= KODA SYSTEMS ======================================================================

// Hello World!
// Console.WriteLine("Hello, World!"); // Writes text to terminal

// Drawing a shape
/*
Console.WriteLine("       /|");
Console.WriteLine("      / |");
Console.WriteLine("     /  |");
Console.WriteLine("    /   |");
Console.WriteLine("   /    |");
Console.WriteLine("  /     |");
Console.WriteLine(" /      |");
Console.WriteLine("/_______|");
*/

// Console.ReadLine(); // Keep console window open until input

// ----------------------------------------------------------------------- VARIABLES -------------------------------------------------------------------------

/*
string name = "Mal";

int age;
age = 21; 

Console.WriteLine("There once was a man named " + name);
Console.WriteLine("He was " + age + " years old");

name = "Malgrieve";
age = 22;

Console.WriteLine("He really liked the name " + name);
Console.WriteLine("But he liked being " + age);
*/

// ----------------------------------------------------------------------- DATA TYPES ------------------------------------------------------------------------

/*
// Text data
string phrase = "Hello man!";
char grade = 'H';

// Number data
int age = 30;
int num = -8;

float digit = 9;
double gpa = 3.67;
// decimal percision = 0;

// True/False data
bool isHere = true;
*/

// ------------------------------------------------------------------------ STRINGS --------------------------------------------------------------------------

/*
Console.WriteLine("Malgrieve");

Console.WriteLine("Blakstar\nIndustries"); // Prints on different Lines
Console.WriteLine("Blackstar\" Industries");

string phrase = "Blackstar Industries";
string phrase1 = "Blackstar"; 
string phrase2 = "Industries";
Console.WriteLine(phrase1 + " " + phrase2);

Console.WriteLine(phrase1.Length); // Characters in string
Console.WriteLine(phrase2.ToUpper()); // Prints in all caps
Console.WriteLine(phrase2.ToLower()); // Prints in all lowercase
Console.WriteLine(phrase1.Contains(phrase2)); // bool if text contains other text

Console.WriteLine(phrase2[0]); // Prints the character in the index position
Console.WriteLine(phrase.IndexOf("Industries")); // Which index pos. does text begin in string (-1, if not there)

Console.WriteLine(phrase.Substring(10)); // Grabs and prints out specific portion
Console.WriteLine(phrase.Substring(10, 6)); // Grabs and prints out specific start, only picks up certain amount
*/

// ------------------------------------------------------------------------ NUMBERS --------------------------------------------------------------------------

/*
Console.WriteLine(400.0550);
Console.WriteLine(600 + 34);
Console.WriteLine(600 - 34);
Console.WriteLine(600 * 34);
Console.WriteLine(600 / 34);
Console.WriteLine(600 % 34);
Console.WriteLine(23 + 600 * (5 - 2) / 34);

int num = 6;
num++;
num--;
Console.WriteLine(num);

Console.WriteLine(Math.Abs(num)); // Absolute value
Console.WriteLine(Math.Pow(num, 3)); // Power of
Console.WriteLine(Math.Sqrt(36)); // Square root

Console.WriteLine(Math.Max(40, 28)); // Maximum number
Console.WriteLine(Math.Min(200,302)); // Minimum number
Console.WriteLine(Math.Round(4.929)); // Round the input number

int num = Convert.ToInt32("400"); // Converts string to int
Console.WriteLine(num + 30);
*/

// ----------------------------------------------------------------------- USER INPUT ------------------------------------------------------------------------

/*
Console.Write("What is your name? > "); // Input prompt
string name = Console.ReadLine(); // Answer variable
Console.Write("How old are you? > "); // Input prompt
string age = Console.ReadLine(); // Answer variable

Console.WriteLine("Hello " + name + ". You are " + age); // Print it out 
Console.ReadLine();
*/

// ------------------------------------------------------------------------ ARRAYS ---------------------------------------------------------------------------

/*
int[] luckyNumbers = { 7, 3, 4, 20, 33};
string[] friends = new string[5];

friends[0] = "Ryan";
friends[1] = "Kaitlyn";

luckyNumbers[2] = 50;

Console.WriteLine(luckyNumbers[4]); // Specify index of element that is

Console.ReadLine();
*/

// ------------------------------------------------------------------------ METHODS --------------------------------------------------------------------------

/*
Console.Write("What is your name? > ");
string name = Console.ReadLine();

SayHi(name);
Console.ReadLine();

static void SayHi(string user)
{
    Console.WriteLine("Hello " + user + "!");
}
*/

// ------------------------------------------------------------------------ RETURN ---------------------------------------------------------------------------

/*
int cubedNumber = cube(5);
Console.WriteLine(cubedNumber);
Console.ReadLine();

static int cube(int num) 
{
    int result = num * num * num;
    return result;
}
*/

// -------------------------------------------------------------------------- IF -----------------------------------------------------------------------------

/*
bool isMale = false;
bool isTall = true;

if (isMale && isTall) 
{
    Console.WriteLine("He is a tall male");
} else if (isMale && !isTall) 
{
    Console.WriteLine("You are male but not tall");
} else if (!isMale && isTall) 
{
    Console.WriteLine("You are not male but are tall");
} else 
{
    Console.WriteLine("She is not male or tall");
}
*/

static int GetMax(int num1, int num2) 
{
    int result;

    if (num1 > num2) 
    {
        result = num1;
    } else 
    {
        result = num2;
    }

    return result;
}

Console.WriteLine(GetMax(2,10));
Console.ReadLine();


// ------------------------------------------------------------------------ SWITCH ---------------------------------------------------------------------------
// ------------------------------------------------------------------------ WHILE ----------------------------------------------------------------------------
// ------------------------------------------------------------------------- FOR -----------------------------------------------------------------------------
// ---------------------------------------------------------------------- 2D ARRAYS --------------------------------------------------------------------------
// ---------------------------------------------------------------------- EXCEPTIONS -------------------------------------------------------------------------
// ------------------------------------------------------------------- CLASSES & OBJECTS ---------------------------------------------------------------------
// --------------------------------------------------------------------- CONSTRUCTORS ------------------------------------------------------------------------
// -------------------------------------------------------------------- OBJECT METHODS -----------------------------------------------------------------------
// ------------------------------------------------------------------- GETTERS & SETTERS ---------------------------------------------------------------------
// ----------------------------------------------------------------- STATIC CLASS ATTRIBUTES -----------------------------------------------------------------
// ----------------------------------------------------------------- STATIC METHODS & CLASSES ----------------------------------------------------------------
// --------------------------------------------------------------------- INHERITANCE -------------------------------------------------------------------------
// ---------------------------------------------------------------------- COMMENTS ---------------------------------------------------------------------------
// ---------------------------------------------------------------------- STRINGS ----------------------------------------------------------------------------