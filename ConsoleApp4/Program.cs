//int number = int.Parse(Console.ReadLine());

//int maxNum = int.MinValue;
//int minNum = int.MaxValue;

//for (int i = 1; i <= number; i++)
//{ 
//int num = int.Parse(Console.ReadLine());
//    if (num > maxNum)
//        maxNum = num;
//        if (num < minNum)
//            minNum = num;
//}
//Console.WriteLine($"Max number: {maxNum}");
//Console.WriteLine($"Min number: {minNum}");



using System;

class Program
{
    static void Main()
    {
        // Четем броя на числата n
       
        int n = int.Parse(Console.ReadLine());

        // Инициализираме променливи за лявата и дясната сума
        int leftSum = 0;
        int rightSum = 0;

        // Четем първите n числа и ги добавяме към лявата сума
        C
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            leftSum += number;
        }

        // Четем следващите n числа и ги добавяме към дясната сума
       
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            rightSum += number;
        }

        // Изчисляваме разликата между лявата и дясната сума по абсолютна стойност
        int difference = Math.Abs(leftSum - rightSum);

        // Проверяваме дали лявата сума е равна на дясната сума и отпечатваме резултата
        if (leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {difference}");
        }
    }
}
