using System;

public static class MathHelper

{
    public static int Factorial(int number)
    {
        int j = 1;
        for (int i = 1; i <= number; i++)
        {
            j = i * j;
        }
        return j;
    }
    public static int GCD(int firstNumber, int secondNumber)
    {
        int result = Math.Min(firstNumber, secondNumber);
        while (result > 0)
        {
            if (firstNumber % result == 0 && secondNumber % result == 0)
            {
                break;
            }
            result--;
        }
        return result;
    }
    public static int LCM(int firstNumberm, int secondNumber)
    {
        int greater = Math.Max(firstNumberm, secondNumber);
        int smallest = Math.Min(firstNumberm,secondNumber);
        for (int i = greater; ; i += greater)
        {
            if (i % smallest == 0)
            {
                return i;
            }
        
        }

    }
}
