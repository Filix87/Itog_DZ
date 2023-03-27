string[] Array = FillArray();
string[] resultArray = NewArray(Array);
//вводим значения чтобы заполнить массив со строками
string[] FillArray()
{
    Console.WriteLine($"Введите значения для строки через запятые, точки или пробел: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', '.', ' ' }; /* разделит значение в массиве если введено через , . или пробел */
    string[] Array = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return Array;
}
//считаем количество символов в строках
int CountSymbols(string[] Array)
{
    int counter = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}
//заполняем новый массив значениями меньше или равному 3 символам
string[] NewArray(string[] Array)
{
    int resultArrayLength = CountSymbols(Array);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}
string PrintArray(string[] Array)
{
    string stringArray = "[";
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
        {
            stringArray += $"\"{Array[i]}\"";
            break;
        }
        stringArray += ($"\"{Array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}
//выводим массив изначальный и итоговый
string firstArray = PrintArray(Array);
string finalArray = PrintArray(resultArray);
Console.WriteLine($"{firstArray}  ->  {finalArray}");