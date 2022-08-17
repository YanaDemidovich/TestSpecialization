// метод проверки длинны массива
string[] Proof(string[] array)
{
    int count = 0;
    string[] result = new string[11];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

// метод вывода на экран
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}

string[] NewArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
Print(Proof(NewArray));

