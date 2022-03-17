// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите строку: ");
string line = Console.ReadLine();
Console.WriteLine("Исходная строка: " + line);

int count = 0;
foreach (var el in line)
    if (char.IsLetter(el)) count++;

Console.WriteLine("Букв в предложение {0}", count);