double f(int num, int s)
{
   double n = Math.Pow(num, s);
   return n; 
}

Console.WriteLine("Insert the numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
// double num = f(a, b);
Console.WriteLine(f(a, b));