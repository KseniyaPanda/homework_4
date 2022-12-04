/*
Задача 29. Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


int[] InitArray(int length)
{
   int[] array = new int[length];
   Random rnd = new Random();
   for (int i = 0; i < length; i++)
   {
      array[i] = rnd.Next(0, 10);
   }
   return array;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}

int[] array = InitArray(8);
PrintArray(array);