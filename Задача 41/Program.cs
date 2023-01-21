//cЗадача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = Convert.ToInt32(Console.ReadLine());
   }
     
    return array;
}

Console.Write("Введите количество чисел ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  числа по одному ");
int[] array = new int[n];
array=FillArrayWithRandom(array);
int count = 0;
for (int i = 0 ; i< array.Length;i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.Write(string.Join(",", array)+" -> "+count);