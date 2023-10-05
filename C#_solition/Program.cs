Console.WriteLine ("Введите длинну массива");
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