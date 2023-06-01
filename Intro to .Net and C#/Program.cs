using System.Text;

void getRepeatChars(string stringToCheck)
{
    StringBuilder sb = new StringBuilder();

    sb.Append('[');

    for (int i = 0; i < stringToCheck.Length; i++)
    {
        if (!(stringToCheck.IndexOf(stringToCheck[i]) == i))
        {
            sb.Append(Char.ToLower(stringToCheck[i]));
            sb.Append(", ");
        }
    }

    sb.Append("]");
    Console.WriteLine("The repeat characters in '{0}' are:", stringToCheck);
    Console.WriteLine(sb.ToString());
}

getRepeatChars("Programmatic Python");
Console.WriteLine();

void getUniqueWords(string sentence)
{
    StringBuilder sb = new StringBuilder();

    sb.Append('[');

    string[] strArray = sentence.ToLower().Split(' ');

    for (int i = 0; i < strArray.Length; i++)
    {
        if (Array.IndexOf(strArray, strArray[i]) == i)
        {
            sb.Append(strArray[i]);
            sb.Append(", ");
        }
    }

    sb.Append(']');
    Console.WriteLine("The unique charactes in the sentence '{0}' are:", sentence);
    Console.WriteLine(sb.ToString());
}

getUniqueWords("To be or not to be");
Console.WriteLine();

void reverseString(string strToBeReversed)
{
    char[] reversedString = new char[strToBeReversed.Length];
    for (int i = 0; i < strToBeReversed.Length; i++)
    {
        reversedString[i] = strToBeReversed[strToBeReversed.Length - i - 1];
    }
    Console.WriteLine("The reverse version of '{0}' is:", strToBeReversed);
    Console.WriteLine(reversedString);
}

reverseString("reverse");
Console.WriteLine();

void getLongestWord(string sentence)
{
    string[] strArray = sentence.Split(" ");

    string longestWord = "";

    for (int i = 0;i < strArray.Length;i++)
    {
        if (strArray[i].Length >= longestWord.Length)
        {
            longestWord = strArray[i];
        }
    }
    Console.WriteLine("The longest word in the sentence '{0}' is:", sentence);
    Console.WriteLine(longestWord);
}

getLongestWord("Tiptoe through the tulips");

/*
 * The main benefit of the StringBuilder class over the String class is that the data type stored within this class is mutable, meaning
 * that the value of the string can be modified without needing to create copies and replace references, this leads to better performance
 * when managing big volumes of string data, this is further boosted with the provided methods 'append, insert, replace and remove'.
 * 
 * The main disadvantage is that StringBuilder does not throw any errors at compile-time, meaning that any miscalculation in the manipulation
 * of the string will only ever be realized in run-time, leading to unexpected errors.
 * The second disadvantage that StringBuilder suffers from is from the inaccesibility of some methods of String, such as 'substring, toUpper, 
 * toLower and split' these can only be accesed after turning the StringBuilder back into a String with .toString()
*/