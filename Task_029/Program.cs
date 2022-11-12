Console.Clear();

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void array(int l)
{
    int[] arr = new int[l];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
   Console.WriteLine($"Массив из {l} элементов [{String.Join(", ", arr)}]");
  

}

array(5);
Console.WriteLine();
array(3);
Console.WriteLine();
array(8);
Console.WriteLine();