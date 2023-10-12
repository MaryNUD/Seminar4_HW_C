int f(int num, int s);
{
   int n = Math.Pow(num, s);
   return n;
}

Console.Write("Insert the numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a, b));

