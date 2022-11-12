Console.Clear();

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



// вариант 1

int numToPow(int[] number)
{
    int pow = number[0];
    int count = 1;
    if (number[1] == 0) pow = 1;

    else
    {

        while (count < number[1])
        {
            pow = pow * number[0];
            count++;

        }
    }
    return pow;
}
Console.WriteLine("Введите 2 целых числа");
int[] num = { Convert.ToInt32(Console.ReadLine()), Math.Abs(Convert.ToInt32(Console.ReadLine())) };

Console.WriteLine($"{num[0]} в степени {num[1]}  равен {numToPow(num)}");

