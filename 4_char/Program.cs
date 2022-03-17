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
int sum = countX + countY;
string result = "Символ '{0}' и '{1}' встречаются в строке {2} раз.";

if (countX + countY > 0)
    Console.WriteLine(result, x, y, sum);
else
    Console.WriteLine("Символы '{0}' и '{1}' не встречаются в строке.", x, y);

Console.ReadKey();
