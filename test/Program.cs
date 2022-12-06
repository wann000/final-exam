// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
string[] workArray = FillArray(); // ввод исходного массива
string firstArray = PrintArray(workArray); // вывод исходного массива
Console.WriteLine(firstArray); // печать исходного массива