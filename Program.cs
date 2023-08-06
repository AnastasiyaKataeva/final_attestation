
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите количество элементов массива: ");
int arrayNum = Convert.ToInt32(Console.ReadLine());

string [] arrayString = new string [arrayNum];
void inputArray(string [] arrayString)
{
    for (int i = 0; i < arrayString.Length; i++ )
    {
        Console.WriteLine($"Введите { i+1 } элемент массива");
        arrayString[i] = Console.ReadLine();
    }
}

string [] filterArray(string [] stringArray)
{
    int num = 0;
    for (int i = 0; i <arrayString.Length; i++)
    {
        if(arrayString[i].Length <= 3)
        num++;
    }

    string [] rezult = new string [num];
    int j = 0;
    for (int i = 0; i< arrayString.Length;i++)
    {
        if(arrayString[i].Length <= 3)
        {
            rezult[j] = arrayString[i];
            j++;
        }
    }
  return rezult;
}
void printArray(string [] arrayString)
{
    Console.Write("[");
    for (int i = 0; i<arrayString.Length; i++)
    {
    Console.Write($"{arrayString[i]}, ");
    }
    Console.Write("]");
}
inputArray(arrayString);
printArray(filterArray(arrayString));
