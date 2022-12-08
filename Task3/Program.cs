// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(double[] array)  
{ 
  for (int i = 0; i < array.Length; i++) 
      array[i] = Math.Round(new Random().NextDouble()*(20 - 10) + 10, 2);    
} 
 
 
double MaxArray(double[] array) 
{ 
  double maxArray = array[0];
  for (int i = 1; i < array.Length; i++)  
    { 
      if(maxArray < array[i]) 
        maxArray = array[i]; 
    } 
    return maxArray;
} 


double MinArray(double[] array) 
{ 
  double minArray = array[0];
  for (int i = 1; i < array.Length; i++)  
    { 
      if(minArray > array[i]) 
        minArray = array[i]; 
    } 
    return minArray;
} 
 
 
Console.Clear(); 
Console.Write("Введите количество элементов массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
double[] array = new double[n]; 
InputArray(array);  
Console.WriteLine($"Полученный массив: [{string.Join(", ", array)}]");  
Console.WriteLine($"Разница между максимальным и минимальным элементом данного массива:  {MaxArray(array) - MinArray(array)}"); 

