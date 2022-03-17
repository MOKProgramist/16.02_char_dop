// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите строку: ");
string line = Console.ReadLine();
Console.WriteLine("Исходная строка: " + line);
Console.WriteLine("Введите символ x: ");
char x = char.Parse(Console.ReadLine());
Console.WriteLine("Введите символ y: ");
char y = char.Parse(Console.ReadLine());

// считаем , предварительно переведя строку в нижний регистр
int countX = line.ToLowerInvariant().Where(a => a == x).Count();
int countY = line.ToLowerInvariant().Where(a => a == y).Count();
string result = "Символ '{0}' встречается чаще в строке.";

if (countX > countY)
    Console.WriteLine(result, x);
else if (countY > countX)
    Console.WriteLine(result, y);
else
    Console.WriteLine("Символы '{0}' и '{1}' встречаются одинаковое количество раз в строке.", x, y);

Console.ReadKey();