/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.*/

int InputNumber(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] Arr(int M)
{
    int[] numbers = new int[M];
    for (int i = 0; i < M; i++)
    {
        numbers[i] = InputNumber($"enter {i + 1} of {M} numbers ");

    }
    return numbers;
}

int CountNum(int[] numbers)
{
    int count = 0;
    foreach (int element in numbers)
    {
        if (element > 0) count++;
    }
    return count;
}

int M = InputNumber("M = ");
int[] myArray = Arr(M);
System.Console.WriteLine($"Count of positive numbers is {CountNum(myArray)}");
