
// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

string palindrom()
{
    System.Console.WriteLine(" Введите 5-и значное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    char[] arr = number.ToString().ToArray();
    if (arr.Length != 5)
    {
        return ("Введите 5-и значное число.");
    }
    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        return ("Число является палиндромом.");
    }

    return ("Число не является палиндромом.");
}
System.Console.WriteLine(palindrom());
