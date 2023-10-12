int f (int x)
{
    int sum = 0;
    while (x > 0) 
    {
        sum = sum + x % 10;
        x = x / 10;
    }
    return sum;
}
Console.Write("Insert the number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(f(n));
