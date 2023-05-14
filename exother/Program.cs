// **Решение задач рекурсией**
// **1 Задача** Собрать строку с числами от a до b, a<= b

// string NumbersFor(int a, int b) // обычное решение
// {
//     string result = String.Empty;
//     for (int i = 0; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b) // решение рекурсией
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


// Другой подход

// string NumbersFor(int a, int b) // обычное решение
// {
//     string result = String.Empty;
//     for (int i = 1; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b) // решение рекурсией
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10



//////////////////////////////////////////////





// **2 Задача** Сумма чисел от 1 до n;

// int SumFor(int n) // обычное решение
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         result += i;
//     }
//     return result;
// }
// int SumRec(int n) // решение рекурсией
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     else
//     {
//         return n + SumRec(n - 1);
//     }
// }

// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55



//////////////////////////////////////////

// **3 Задача** Факториал числа;

// int FactorialFor(int n) // обычное решение
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }
// int FactorialRec(int n) // решение рекурсией
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800

// ** 4 Задача** Вычислить a \n - степени

// int PowerFor(int a, int n) // обычное решение
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n) // решение рекурсией
// {   //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024

/////////////////////////////////////////////////

//**5 Задача** пеебор слов

char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)//если однобуквенные
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)//если трехбуквенные
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)//если пятибуквенные и т.д.
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
                }
            }
        }
        
    }
}

// общее решение

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

// FindWords ( "аисв", new char(5));/// надо поглядеть не понял ка исправить










