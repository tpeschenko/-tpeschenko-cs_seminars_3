// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void zadacha_21()
{
    Console.WriteLine("программа находит расстояние между точками в 3D пространстве");
    Random rand = new Random();
    double x1 = rand.Next(-5, 6);
    Console.WriteLine($"Координаты точки x1 = {x1}");
    double y1 = rand.Next(-5, 6);
    Console.WriteLine($"Координаты точки x1 = {y1}");
    double z1 = rand.Next(-5, 6);
    Console.WriteLine($"Координаты точки x1 = {z1}");
    double x2 = rand.Next(-5, 6);
    Console.WriteLine($"Координаты точки x1 = {x2}");
    double y2 = rand.Next(-5, 6);
    Console.WriteLine($"Координаты точки x1 = {y2}");
    double z2 = rand.Next(-5, 6);
    Console.WriteLine($"Координаты точки x1 = {z2}");
    
    double result = 0;

    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между точками: {result}");







}


zadacha_21();
