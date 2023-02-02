
// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int coordinate(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int x1 = coordinate("Введите координату х1: ");
int y1 = coordinate("Введите координату y1: ");
int z1 = coordinate("Введите координату z1: ");
int x2 = coordinate("Введите координату x2: ");
int y2 = coordinate("Введите координату y2: ");
int z2 = coordinate("Введите координату z2: ");

System.Console.WriteLine(
    Math.Round(
        Math.Sqrt(Math.Pow((x2 - x1), 2) +
                  Math.Pow((y2 - y1), 2) +
                  Math.Pow((z2 - z1), 2)
        ), 2
    )
);