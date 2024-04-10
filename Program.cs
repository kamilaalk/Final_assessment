string[] array1 = new string[5] {"hi", "qwepop", "I<3", "you", "pretty"};
string[] array2 = new string[array1.Length];

void MakeSecondArray(string[] array1, string[] array2)
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

void ShowArray(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}

MakeSecondArray(array1, array2);
ShowArray(array2);