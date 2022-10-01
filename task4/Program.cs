// Дано три целых числа. Требуется определить, какие из заданных чисел являются простыми, и вычислить их сумму. 
// Также требуется проверить, является ли полученная сумма простыми числом.
Console.Clear();

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 1000);
}

int ReleaseArray(int[] array)
{
    int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] == 2 || array[i] == 3 || array[i] == 5 || array[i] == 7)
    sum = sum + array[i];
else 
    {
        if (array[i] % 2 != 0 && array[i] % 3 != 0 && array[i] % 5 != 0 && array[i] % 7 != 0)
            sum = sum + array[i];
    }
}
return sum;
}

int[] array = new int[3];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма простых чисел равна {ReleaseArray(array)}"); 

int result = ReleaseArray(array);
    string Summa(int result)
{ 
          if (result == 2 || result == 3 || result == 5 || result == 7)
      return "Полученная сумма является простым числом";
  else 
      {
          if (result % 2 != 0 && result % 3 != 0 && result % 5 != 0 && result % 7 != 0)
             return "Полученная сумма является простым числом";
         return "Полученная сумма не является простым числом";
      }
  }
Console.WriteLine(Summa(result));
