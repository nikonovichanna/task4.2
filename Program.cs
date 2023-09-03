int a = Promt("Введите число:");
System.Console.WriteLine($"Сумма чисел {GetSumN(a)}"); 

int Promt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result =int.Parse(readInput);
    return result;
}

int GetSumN(int a)
{
    int tmp = 0;
    int summ = 0;

    while(a > 0)
    {
        tmp = a % 10;
        a = a / 10;
        summ = summ + tmp;
    }    

    return summ;
}
