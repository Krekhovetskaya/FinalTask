using System;
using static System.Console;
Clear();

string[] array1 = new string[6] {"025", "307", "gbrt", "final", "5", "ok"};
string[] array2 = new string[array1.Length];

GetNewArray(array1, array2);
PrintArray(array2);

void GetNewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
   WriteLine();
}

