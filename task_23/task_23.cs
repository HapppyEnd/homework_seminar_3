// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

string NumberCub()
{
    System.Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string result = "";
    for (int i = 1; i <= number; i++)
    {
        result += Math.Pow(i, 3) + " ";

    }
    return result;
}
System.Console.WriteLine(NumberCub());
