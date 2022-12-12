//Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно палиндромом.


void MetPalindrom(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"{number} - палиндром.");
  }
  else Console.WriteLine($"{number} - не палиндром.");
}

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
  MetPalindrom(number);
}
else Console.WriteLine($"Введи пятизначное число");


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит
//расстояние между ними в 3D пространстве.

double MetDist3D(double x1, double y1,double z1, double x2, double y2, double z2)
{
double x =  x2 - x1;
double y =  y2 - y1;
double z =  z2 - z1;

double gip = Math.Pow(x,2) + Math.Pow(y,2)+Math.Pow(z,2);
double result = Math.Sqrt(gip);
return result;
}

Console.Write("Введите координату Х для А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для А: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Х для B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для B: ");
double zB = Convert.ToDouble(Console.ReadLine());
double res = Math.Round(MetDist3D(xA,yA,zA,xB,yB,zB),2);
Console.WriteLine($"Длина отрезка между А и В {res}");


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//кубов чисел от 1 до N.

double MetQube(double num)
{
    double res=0;
    for(int i=1; i<=num; i++)
    {
        res=Math.Pow(i,3);
        Console.WriteLine($"{i} в кубе = {res}  ");
    }
    return res;
}
Console.WriteLine("Введите число N = ");
double n = Convert.ToDouble(Console.ReadLine());
MetQube(n);
