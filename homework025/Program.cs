/*
Задача 25. Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while (!isCorrect)
   {
      Console.WriteLine(message);

      if (int.TryParse(Console.ReadLine(), out result))
      {
         isCorrect = true;
      }
      else
      {
         Console.WriteLine("Введите корректное число");
      }
   }

   return result;
}

int number = GetNumber("введите число");
int extent = GetNumber("введите степень");
int result = 1;
for (int i = 1; i <= extent; i++)
{
   result = result * number;
}

Console.WriteLine($"число {number} в степени {extent} = {result}");
