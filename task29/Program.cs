int[] fillArray(int Length, int min, int max)
{
    int [] array = new int[Length];
    for(int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int[] array = fillArray(7, 0, 30);
Console.Write(String.Join(", ", array));