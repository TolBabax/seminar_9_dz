// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int IntupNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено не корректное число. Попробуйте еще раз.");
    }
    return number;
}


int Akerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akerman(m - 1, Akerman(m, n - 1));
    }
    return 0;
}

int numberM = IntupNumber("Введите число M: ");
int numberN = IntupNumber("Введите число N: ");
System.Console.WriteLine();


int akerman = Akerman(numberM, numberN);
System.Console.WriteLine(akerman);