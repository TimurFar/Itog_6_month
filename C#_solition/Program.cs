﻿Console.WriteLine ("Введите длинну массива");
int size = int.Parse (Console.ReadLine()!);
string [] Array  = new string[size];
Console.WriteLine ("Введите элементы массива");
for (int i = 0; i < size; i++)
{
 Array [i] = Console.ReadLine()!;
}
Console.WriteLine ();
Console.WriteLine ("Исходный массив");
Console.WriteLine ($"[{String.Join(',', Array)}]");

int Index = 0;
string [] NewArray = new string[size];
for (int i = 0; i < size; i++)
{
    if (Array[i].Length <=3)
    {
     NewArray [Index] = Array [i];
    Index++;
    }
  }
Console.WriteLine ();
Console.WriteLine ("Промежуточный массив");
Console.WriteLine ($"[{String.Join(',', NewArray)}]");

// Console.WriteLine ();
// Console.WriteLine ("Элементов массива  <=3 " + Index);
Console.WriteLine ();
Console.WriteLine ("Итоговый массив");
int newIndex = 0;
string [] ResultArray = new string [Index];
for (int i = 0; i < Index; i++)
{
if (NewArray[i].Length <=3)
    {
    ResultArray[newIndex] = NewArray [i];
    newIndex++;
    }
}
Console.WriteLine ($"[{String.Join(',', ResultArray)}]");
Console.WriteLine ();