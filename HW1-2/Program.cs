Console.Clear();

Console.WriteLine("Введите первое число: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");

int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 & number1 > number3)
{
  Console.WriteLine("max number1: " + number1);
}
if (number2 > number1 & number2 > number3)
{
  Console.WriteLine("max number2: " + number2);
}
if (number3 > number1 & number3 > number2)
{
  Console.WriteLine("max number3: " + number3);
}
if (number1 == number2 & number1 == number3)
{
  Console.WriteLine("number1 = number2 = number3, Max: " + number1);
}
if (number1 == number2 & number1 > number3)
{
  Console.WriteLine("number1 = number2, Max: " + number1);
}
if (number1 == number3 & number1 > number2)
{
  Console.WriteLine("number1 = number3, Max: " + number1);
}
if (number2 == number3 & number2 > number1)
{
  Console.WriteLine("number2 = number3, Max: " + number2);
}