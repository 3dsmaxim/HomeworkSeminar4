// Console.Clear();


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int sumNumbers(string num)
{
    
    int numB = int.Parse(num);
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        sum = sum + numB%10;
        numB = numB/10;

    }
    return sum;
}




Console.WriteLine($"Введите целое число");
string number = Console.ReadLine();
Console.WriteLine(sumNumbers(number));