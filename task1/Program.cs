// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int SumRecursion(int A, int B)
{
    
    if (B > A)
    {
        return B + SumRecursion(A, B - 1);
        
    }
    if (A > B)
    {
        return A + SumRecursion(A - 1, B);
    }

    return  B;
}

int numberM = IntupNumber("Введите число M: ");
int numberN = IntupNumber("Введите число N: ");
System.Console.WriteLine();

System.Console.WriteLine($"Cумма натуральных элементов в промежутке от {numberM} до {numberN}: " + SumRecursion(numberM, numberN));

