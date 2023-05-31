using System.Text;

char[] getRepeatChars(string stringToCheck)
{
    char[] charArray;
    for (int i = 0; i < stringToCheck.Length; i++)
    {
        if (!(stringToCheck.IndexOf(stringToCheck[i]) == i))
        {
            charArray.Append(stringToCheck[i]);
        }
    }
    return charArray;
}

getRepeatChars("The World Revolving!");

string[] getUniqueWords()
{
    string[] stringArray = new string[5];
    return stringArray;
}

string reverseString()
{
    return "reversed string";
}

string getLongestWord()
{
    return "Longest word";
}

StringBuilder strBldr = new StringBuilder();
// check constructor definition

strBldr.Append("Hello");
strBldr.Append(" ");
strBldr.Append("World");
strBldr.Append("!");

strBldr.Replace(" ", null, 0, strBldr.Length);

