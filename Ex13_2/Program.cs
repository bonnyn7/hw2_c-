// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

internal partial class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Введите число: ");
        // int val = Convert.ToInt32(Console.ReadLine());
        // ИЛИ
        Random rnd = new Random();
        int val = rnd.Next(10, 1000);
        Console.WriteLine("Число: " + val);
        string str = Convert.ToString(val);
        if (str.Length > 2)
        {
            Console.WriteLine("Третья цифра числа: " + str[2]);
        }
        else
        {
            Console.WriteLine("Третья цифра отсутствует");
        }
    }
}