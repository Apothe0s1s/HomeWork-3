// Задача 19. Проверка 5-значного числа на полиндром.

// Console.WriteLine("Введите пятизначное число ");
// int N = Convert.ToInt32(Console.ReadLine());

// if ((N > 9999) && (N < 100000) && (N % 10) == (N / 10000)%10 && ((N / 10)%10) == ((N / 1000)%10))
//     Console.Write("Полиндром");
// else if (N < 10000 || N > 99999)
// {
//     Console.Write("Не пятизначное число");
// }
// else
// {
//     Console.Write("Не полиндром");
// }

// _____________________________________________________________________
// Задача 21. Нахождение расстояния между точками в 3D пространстве.
// AB = √(x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2

// Console.WriteLine("Введите координаты: ");

// Console.Write("Введите координаты x1: ");
// double x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты x2: ");
// double x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты y1: ");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты y2: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты z1: ");
// double z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты z2: ");
// double z2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.Write("Расстояние между двумя точками в пространстве равно " +result);

// ___________________________________________________________________________________
// // Задача 23. Выдаёт таблицу кубов от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++) 
Console.WriteLine(i*i*i);