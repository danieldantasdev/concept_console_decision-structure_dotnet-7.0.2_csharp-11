// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a string of numbers separated by spaces: ");
// 0 1 2 3 4 5 6 7 8 9 10
var numbers = Console.ReadLine().Split(" ");

//for
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

//foreach
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

//while
var cont = 0;

while (cont < numbers.Length)
{
    Console.WriteLine(numbers[cont]);
    cont++;
}

Console.ReadKey();