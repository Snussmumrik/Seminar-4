//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 1. Input
int A = GetNumberAFromUser("Введите целое число A", "Ошибка ввода");

// 2. Input2
int B = GetNumberBFromUser("Введите целое число B", "Ошибка ввода");

// 3. Calculation
int result = PowNumber(A);

// 4. Output
Console.WriteLine($"{A} --> {result}");

////////////////////////////////////////////////////////


int GetNumberAFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int UserNumberA))
            return UserNumberA;

        Console.WriteLine(errorMessage);
    }
}

int GetNumberBFromUser(string message2, string errorMessage)
{
    while(true)
    {
        Console.Write(message2);
        if(int.TryParse(Console.ReadLine(), out int UserNumberB))
            return UserNumberB;

        Console.WriteLine(errorMessage);
    }
}

int PowNumber(int number)
{
    int i = UserNumberB;
    int Pow = 0;

    while( i !=0 );
    {
        Pow = UserNumberA * UserNumberA;
        i--;
    }

    return Pow;
}