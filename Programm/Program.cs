// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длинна которых меньше либо равна 3 символа.
Console.Clear();
string[] GetNewArray(string[] firstArray)
{
    string[] newArray = new string[firstArray.Length];
    int realSize = 0;
    for (var i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[realSize] = firstArray[i];
            realSize++;
        }
    }
    Array.Resize(ref newArray, realSize);
    return newArray;
}