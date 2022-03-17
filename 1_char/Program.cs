// See https://aka.ms/new-console-template for more information
using System.Text;
// заменить буквы местами 
Console.WriteLine("Заменяют буквы местами");

Console.WriteLine("Введите строку: ");
StringBuilder a = new StringBuilder(Console.ReadLine());

for (int i = 0; i < a.Length - 1; i += 2) // перебор с интервалом два символа.
{
    var c = a[i + 1]; // Вспомогательная переменная для обмена символами.
    a[i + 1] = a[i];
    a[i] = c;
}
Console.WriteLine(a.ToString());
Console.ReadKey();