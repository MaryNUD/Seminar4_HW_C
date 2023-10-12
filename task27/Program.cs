void f (int x);
{
    int i = 0;
    while (x > 0) 
    {
        i = i + x % 10;
        x = x / 10;
    }
}
Console.Write("Insert the number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(f(n));
