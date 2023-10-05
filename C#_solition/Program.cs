Console.WriteLine ("Введите длинну массива"); // Выводим сообщение
int size = int.Parse (Console.ReadLine()!); //Задаём размер массива
string [] Array  = new string[size]; // Создаём массив с типом данных string и задаём его размер 
Console.WriteLine ("Введите элементы массива"); // Выводим сообщение
for (int i = 0; i < size; i++)
{
 Array [i] = Console.ReadLine()!; // Задаём элементы массива
}
Console.WriteLine ();  // Выводим пустую строку
Console.WriteLine ("Исходный массив"); // Выводим сообщение
Console.WriteLine ($"[{String.Join(',', Array)}]"); // Выводим массив в одну строку

int Index = 0; // Задаём значение переменной
string [] NewArray = new string[size]; // Создаём массив с типом данных string и задаём его размер 
for (int i = 0; i < size; i++)
{
    if (Array[i].Length <=3)
    {
     NewArray [Index] = Array [i]; // Заполняем временный массив согласно условию
    Index++;
    }
  }
Console.WriteLine (); // Выводим пустую строку
Console.WriteLine ("Промежуточный массив"); // Выводим сообщение
Console.WriteLine ($"[{String.Join(',', NewArray)}]"); // Выводим массив в одну строку

// Console.WriteLine ();
// Console.WriteLine ("Элементов массива  <=3 " + Index);

Console.WriteLine (); // Выводим пустую строку
Console.WriteLine ("Итоговый массив"); // Выводим сообщение
int newIndex = 0;
string [] ResultArray = new string [Index]; // Создаём массив с типом данных string и задаём его размер 
for (int i = 0; i < Index; i++)
{
if (NewArray[i].Length <=3)
    {
    ResultArray[newIndex] = NewArray [i]; // Заполняем итоговый массив согласно условию
    newIndex++;
    }
}
Console.WriteLine ($"[{String.Join(',', ResultArray)}]"); // Выводим массив в одну строку
Console.WriteLine (); // Выводим пустую строку