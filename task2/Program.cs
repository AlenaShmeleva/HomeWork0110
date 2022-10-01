// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

void InputArray(int [] array)
{ for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 1001);
}

int ReleaseArray( int [] array)
{ 
    int count = 0;
    for ( int i = 1; i < array.Length; i = i + 2)
    {
        count++;
    }
    return count;
}

Console.WriteLine("Ввведите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.Write("Ответ: ");
Console.Write(ReleaseArray(array));