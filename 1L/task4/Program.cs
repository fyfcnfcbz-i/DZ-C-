// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// int N = new Random().Next(0,100000);
// Console.WriteLine(N);


// if(N < 10)
// {
//     Console.WriteLine(N);
// }
// else
// {
//     while(N > 0) 
//     {
//         int R = N % 10;
//         N /= 10;
//         if (N > 0)
//         {
//             Console.Write($"{R}, ");
//         }
//         else
//         {
//             Console.Write($"{R}");
//         }
//     }
// }

// else
// {
//     // Создаем массив для хранения цифр числа
//     int[] digits = new int[N.ToString().Length];
//     int index = 0;

//     while (N > 0)
//     {
//         int R = N % 10;
//         N /= 10;
//         digits[index] = R; // Сохраняем цифру в массиве
//         index++;
//     }

//     // Выводим цифры в обратном порядке
//     for (int i = digits.Length - 1; i >= 0; i--)
//     {
//         Console.Write($"{digits[i]}");
//         if (i > 0)
//         {
//             Console.Write(", ");
//         }
//     }
// }


Console.Write("Введите трехзначное целое число N: ");
string N = Console.ReadLine()!; // переменная N принимает значение string, 
                                //т.к конструкция Console.ReadLine() имеет строковое значение 
                                //и отсутсвует Конвектор Convert.ToInt32
int i = 0;

while (i < N.Length)
{
    if (i < N.Length - 1)
    {
        Console.Write($"{N[i]}, ");
    }
    else
    {
        Console.Write($"{N[i]}");
    }
    i++;
}

