int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
void fill(int[] collection);
{
    int length = collection.length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 101);
        index++;
    }
}

// Не понимаю почему, то что делали на лекциях не работает... Вроде как пишу то же,что и было показано.