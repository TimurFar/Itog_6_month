Console.WriteLine ("Введите длинну массива");
int size = int.Parse (Console.ReadLine()!);
string [] Array  = new string[size];
Console.WriteLine ("Введите элементы массива");
for (int i = 0; i < size; i++)
{
 Array [i] = Console.ReadLine()!;
}
 Console.WriteLine ("Исходный массив");
Console.WriteLine ($"[{String.Join(',', Array)}]");
