// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

// Функция ввод массива
string[] FillArray()
{
    Console.WriteLine("Введите данные через пробел, по окончании ввода нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}    

// Функция вывод массива
string PrintArray(string[] workArray)
{
    string stringArray = "[";
    for (int i = 0; i < workArray.Length; i++)
    {
        if (i == workArray.Length - 1)
        {
            stringArray += $"\"{workArray[i]}\"";
            break;
        }
        stringArray += ($"\"{workArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

// Функция подсчета количества элементов меньше либо равных 3м символам
int CountStringSymbols(string[] workArray)
{
    int counter = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}


// Функция создания нового массива из элемтов меньше либо равных 3 символам
string[] GenerateNewArray(string[] workArray)
{
    int resultArrayLength = CountStringSymbols(workArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}

string[] workArray = FillArray(); // ввод исходного массива
Console.Clear();
string[] resultArray = GenerateNewArray(workArray); // создание результирующего массива
string firstArray = PrintArray(workArray); // печать исходного массива
string secondArray = PrintArray(resultArray); // печать результирующего массива
Console.WriteLine(firstArray);
Console.WriteLine(" -> ");
Console.WriteLine(secondArray);