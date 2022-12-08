// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

 
 void InputArray(int[] array) // Процедура для заполнения массива
{
  for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(100, 1000);   
}


int ReleaseArray(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++) // Прохождение по массиву
  {
     if (array[i] % 2 == 0)
     count++;
  } 
  return count;
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // Создаем сам массив в котором количество элементов = n.
InputArray(array); // Процедура заполнения нашего одномерного массива
Console.WriteLine($"[{string.Join(", ", array)}]"); // Выводим заданный массив
Console.WriteLine($"В данном массиве четных чисел: {ReleaseArray(array)}"); // Запускаем процедуру