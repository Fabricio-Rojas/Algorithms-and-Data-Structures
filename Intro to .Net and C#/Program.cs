void findRepeatElems(int[] numsArray)
{

}

int[] repearArr = { 1, 2, 3, 4, 7, 9, 2, 4 };
findRepeatElems(repearArr);
Console.WriteLine();

void mergeSortedArrays(int[] array1, int[] array2)
{
    int[] mergedArr = new int[array1.Length + array2.Length];
    Array.ConstrainedCopy(array1, 0, mergedArr, 0, array1.Length);
    Array.ConstrainedCopy(array2, 0, mergedArr, array1.Length, array2.Length);
    Array.Sort(mergedArr);

    Console.WriteLine("The sorted result of merging the two provided arrays is:");

    string joined = string.Join(", ", mergedArr); // better method
    
    //for (int i = 0; i < mergedArr.Length; i++)
    //{
    //    Console.Write("{0}, ", mergedArr[i]);
    //}

    Console.WriteLine(joined);
    Console.WriteLine();
}

int[] intArr1 = { 1, 2, 3, 4, 5 };
int[] intArr2 = { 2, 5, 7, 9, 13 };

mergeSortedArrays(intArr1, intArr2);
Console.WriteLine();

void reverseIntOrder(int numToReverse)
{
    string numString = numToReverse.ToString();
    char[] reversedNums = new char[numString.Length];
    for (int i = 0; i < numString.Length; i++)
    {
        reversedNums[i] = numString[numString.Length - i - 1];
    }
    int result = Int32.Parse(reversedNums);
    Console.WriteLine("The reverse version of '{0}' is:", numToReverse);
    Console.WriteLine(result);
}

reverseIntOrder(3415);
Console.WriteLine();
