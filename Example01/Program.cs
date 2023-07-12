Console.Clear();
Console.Write("x1= ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1= ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2= ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2= ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("x3= ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("y3= ");
int y3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1-x2-x3, 2) + Math.Pow(y1-y2-y3, 2)), 3));
