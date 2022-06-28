// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число, соответствующее дню недели: ");
        int day = Convert.ToInt32(Console.ReadLine());
        void check (int day)
        {
        if (day == 6 || day == 7) 
        {
            Console.WriteLine("Это выходной день");
        }
        else if (day < 1 || day> 7)
        {
            Console.WriteLine("Такого дня нет");
        }
        else 
        {
            Console.WriteLine("Это не выходной день");
        }
        }
        check(day);
    }
}