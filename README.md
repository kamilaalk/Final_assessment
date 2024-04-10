# Итоговая контрольная работа по основному блоку

Первым делом мы объявляем два массива, в array1 уже определена длина и сами строки. Array2 пока пустой, но ему выделяется место в памяти согласно заданной длине Array1.

```sh
string[] array1 = new string[5] {"hi", "qwepop", "I<3", "you", "pretty"};
string[] array2 = new string[array1.Length];
```
Далее у нас описывается метод **MakeSecondArray**,  суть которого заключается в том, чтобы пройдя по каждой строке в array1, проверить условие (длина должна быть меньше или равна 3). Если это так, то эта строка поочередно добавляется в массив array2.

```sh
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
```

Следующий метод **ShowArray** отвечает за вывод массива array2 на консоль. Он проходится по каждой строке в массиве с помощью цикла **for**, а затем выводит ее на экран.

```sh
void ShowArray(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}
```

В конце мы объявляем два метода, которые и приводят в действие нашу программу.

```sh
MakeSecondArray(array1, array2);
ShowArray(array2);
```