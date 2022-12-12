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

/*
// Итерационная функция для проверки, является ли заданное число палиндромом или нет
double isPalindrome(double num)
{
    // `n` сохраняет заданное целое число
    double n = num;
 
    // `rev` хранит обратную сторону заданного целого числа
    double rev = 0;
 
    while (n>rev)
    {
        // это сохранит последнюю цифру `n` в переменной `r`
        // например, если `n` равно 1234, то `r` будет равно 4
        double r = n % 10;
 
        // добавляем `r` к `rev` вместо себя
        // например, если `rev = 65` и `r = 4`, то новый `rev` будет 654
        rev = rev * 10 + r;
 
        // удалить последнюю цифру из `n`
        // например, если `n` равно 1234, то новое `n` будет 123
        n = n / 10;
    }
 
    // это выражение вернет 1, если заданное число равно
    // наоборот; в противном случае он вернет 0
    return n=rev;
    
}
    Console.WriteLine("Введите число ");
    double n = Convert.ToDouble(Console.ReadLine());
   if (isPalindrome(n)) 
   {
        Console.WriteLine("Palindrome");
    }
    else {
        Console.WriteLine("Not Palindrome");
    }*/

/*
int reverse(int num, int acc)
{
    while (num > 0)
{ 
    acc = acc * 10 + num % 10; 
    num /= 10; 
}
    return acc;
}
    
int n = Convert.ToInt64(Console.ReadLine());
    Console.WriteLine((n == 0) || (reverse(n, 0) == n));
    Console.WriteLine(true);
*/
/*
bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}

Console.WriteLine("Введите число ");
    int n = Convert.ToInt64(Console.ReadLine());
    isPalindrome(n); 
    */