// Задает массив и выводит его на экран в [] скобках
Console.WriteLine("Введите массив чисел из 8 элементов");
int[] array = new int[8];
VvodArray(array);
PrintArray(array);

//Ввод элементов массива с консоли
void VvodArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
