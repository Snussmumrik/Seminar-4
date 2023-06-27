// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 1. Input
int A = GetNumberFromUser("Введите целое число A", "Ошибка ввода");

// 2. Calculation
int result = SumNumber(A);

// 3. Output
Console.WriteLine($"сумма цифр в числе --> {result}");

////////////////////////////////////////////////////////


int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int UserNumber))
            return UserNumber;

        Console.WriteLine(errorMessage);
    }
}

int SumNumber(int number)
{
    int sum = 0;
    while (A > 0)
    {
        sum = sum + A % 10;
        A = A /10 ;
    }

    return sum;
}