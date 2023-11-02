int n = int.Parse(Console.ReadLine());
int sumOfNumbers = 0;
for (int i = 0; i < n; i++)
{ 
    int number = int.Parse(Console.ReadLine());
    sumOfNumbers += number;
}
Console.WriteLine(sumOfNumbers);