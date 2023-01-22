// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

int [] generateArray (int lenght, int start, int end)
{
    int [] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(start, end +1);
    }
    return result;
}

void printArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("[");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(array[i]);
        Console.ResetColor();
        if (i < array.Length - 1)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(", ");
            Console.ResetColor();
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("]");
    Console.ResetColor();
}

int getSumOfUnevenPosition(int[] array)
{
    int sum = 0;      
    for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            sum = sum + array[i];      
        }
        return sum;
}
int[] Array = generateArray(6,0,30);
printArray(Array);
int sum = getSumOfUnevenPosition(Array);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях - {sum}");
Console.ResetColor();