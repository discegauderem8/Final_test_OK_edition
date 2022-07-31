

string[]initialArray = {"aghja", "ajana", "a", "adidas", "bb"} ;

string[]finalArray = new string[initialArray.Length];

int count = 0;

for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length >= 3)
    {
        finalArray[count] = initialArray[i];
        count++;
    }
}

for (int k = 0; k < finalArray.Length; k++)
{
    {
        Console.WriteLine(finalArray[k]);
    }
}

