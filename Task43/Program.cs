﻿Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;
x = (b2 - b1) / (k1 - k2);
y = (k1 * b2 - k2 * b1) / (k1 - k2);
Console.WriteLine($"Точка пересечения прямых: ({x};{y})");
