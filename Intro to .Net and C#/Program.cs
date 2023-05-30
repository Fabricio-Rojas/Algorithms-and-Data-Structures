Console.WriteLine("Please enter a number");

string numInput = Console.ReadLine();

while (!Int32.TryParse(numInput, out int value) || Int32.Parse(numInput) <= 0)
{
    Console.Clear();
    Console.WriteLine("Please input a valid positive number!");
    numInput = Console.ReadLine();
}

int n = Int32.Parse(numInput);

Console.WriteLine("Please enter " + n + " words");

string[] wordsArray = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Word n°{0}:", i + 1);

    wordsArray[i] = Console.ReadLine();

    while (wordsArray[i].Contains(" ") || Int32.TryParse(wordsArray[i], out int value) || wordsArray[i].Length <= 0)
    {
        Console.Clear();
        Console.WriteLine("Please dont enter spaces or numbers");
        wordsArray[i] = Console.ReadLine();
    }
}

Console.WriteLine("Please enter a character");

char charToCount = Console.ReadKey().KeyChar;

while (!Char.IsLetter(charToCount))
{
    Console.Clear();
    Console.WriteLine("Please enter a letter, not a number!");
    charToCount = Console.ReadKey().KeyChar;
}

Console.WriteLine();

int letterCount = 0;
int totalLetterCount = 0;

foreach (string str in wordsArray)
{
    foreach (char c in str.ToLower())
    {
        if (Char.ToLower(c) == Char.ToLower(charToCount))
        {
            letterCount++;
        }
        totalLetterCount++;
    }
}

Console.WriteLine("The character '" + charToCount + "' appears " + letterCount + " times in the array.");
if ((letterCount * 100) / totalLetterCount > 25)
{
    Console.WriteLine("This letter makes up more than 25% of the total number of characters");
}