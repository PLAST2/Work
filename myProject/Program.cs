using System;
Console.Clear();
//Console.WriteLine("Enter any symbols");
string[] array1;

array1 = ["aada", "d", "dd", "adaaw", "daaaadd", "da"];

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
        count++;
}

string[] array2 = new string[count];

int index = 0;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[index] = array1[i];
        index++;
    }
}

Console.WriteLine(string.Join(", ", array2));


