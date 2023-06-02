using System.Text;

int GetHighestValueInList(List<int> list)
{
    int highestVal = 0;

    foreach (int num in list)
    {
        if (num > highestVal)
        {
            highestVal = num;
        }
    }

    return highestVal;
}

List<int> MaxNumbersInLists(List<List<int>> list)
{
    List<int> result = new List<int>();

    foreach (List<int> l in list)
    {
        result.Add(GetHighestValueInList(l));
    }

    return result;
}
// Time Complexity: O(n^2)

List<List<int>> list1 = new List<List<int>>
{
    new List<int> {1, 5, 3},
    new List<int> {9, 7, 3, -2},
    new List<int> {2, 1, 2}
};
List<int> result1 = MaxNumbersInLists(list1);

StringBuilder sb1 = new StringBuilder();
for (int i = 0; i < result1.Count; i++)
{
    sb1.Append($"List {i +1} has a maximum of {result1[i]}. ");
}
Console.WriteLine(sb1.ToString());

string HighestGrade(List<List<int>> list)
{
    int highestGrade = 0;
    int highestIndex = 0;

    foreach (List<int> l in list)
    {
        if (GetHighestValueInList(l) > highestGrade) 
        { 
            highestGrade = GetHighestValueInList(l); 
        }

        if (l.Contains(highestGrade))
        {
            highestIndex = list.IndexOf(l);
        }
    }

    return $"The highest grade is {highestGrade}. This grade was found in class(es) {highestIndex + 1}";
};
// Time Complexity: O(n^2)

List<List<int>> list2 = new List<List<int>>
{
    new List<int> {85, 92, 67, 94, 94},
    new List<int> {50, 60, 57, 95},
    new List<int> {95}
};
Console.WriteLine(HighestGrade(list2));

List<int> OrderByLooping(List<int> list)
{
    return list;
};
// Time Complexity: 

List<int> list3 = new List<int> { 6, -2, 5, 3 };
OrderByLooping(list3);