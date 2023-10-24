// Задать массив на 10 целых чисел. Написать программу которая определяет количество чётных чисел в массиве

int namber = 0;
int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
    int a = array[i] % 2;
    if (a == 0)
    {
        namber = namber + 1;
    }
}
Console.WriteLine(" - " + namber);
