// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

void InputArray(double [] array)
{ for (int i = 0; i < array.Length; i++)
    array[i] = new Random().NextDouble() * 10;
}

double ReleaseArray( double [] array)
{ 
    double result = 0;
    double min = array[0];
    double max = array[0];
    for ( int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else 
            {
                if (array[i] < min)
                    min = array[i];
            }
        result = max - min;
    }

    return result;
}

Console.WriteLine("Ввведите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double [n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Разность между максимальным и минимальным элементом равна {ReleaseArray(array)}");