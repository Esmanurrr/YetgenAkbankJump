Console.WriteLine("Extension Methods");

#region Example
int[] numberArray = { 1, 10, 2, 3, 3, 4, 4, 4 };

int maxNumberOfArray = numberArray.Max();

int uniqueMembersCount = numberArray.Distinct().Count();

int secondNumberOfArray = numberArray.ReturnSecondNumberOfArray();

string rawName = "Esmanur_Mazlum";

rawName.GetLastName();

Console.WriteLine();
#endregion

static class MyExtensions
{
    public static string GetLastName(this string fullName)
    {
        return fullName.Split('_')[1];
    }


    public static int ReturnSecondNumberOfArray(this int[] arr)
    {
        if (arr.Length >= 2)
            return arr[1];

        throw new Exception("Array must be longer then one element");
    }
}