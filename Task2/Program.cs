// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

 void InputArray(int[] array) // Процедура для заполнения массива
{
  for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-100, 100);   
}


int ReleaseArray(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i += 2) // Прохождение по массиву
     sum += array[i];
  
  return sum;
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // Создаем сам массив в котором количество элементов = n.
InputArray(array); // Процедура заполнения нашего одномерного массива
Console.WriteLine($"[{string.Join(", ", array)}]"); // Выводим заданный массив
Console.WriteLine($"Сумма элементов нечетных позиций: {ReleaseArray(array)}"); // Запускаем процедуру
