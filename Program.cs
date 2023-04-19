//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//  коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите массив строк: ");
String[] inputArray = Console.ReadLine().Split(" ");
String[] outputArray = new String[inputArray.Length];
int outputArraySize = 0;
foreach (String s in inputArray) 
{
    if (s.Length <=3) outputArray[outputArraySize++] = s;
}
if (outputArraySize > 0) Console.WriteLine(String.Join(" ",outputArray));
else Console.WriteLine("Все элементы исходного массива длиннее 3-х символов");