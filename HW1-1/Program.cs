Console.Clear();

Console.WriteLine("Введите первое число: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
  Console.WriteLine("max number: " + number1 + " min number: " + number2);
}
if (number1 < number2)
{
  Console.WriteLine("max number: " + number2 + " min number: " + number1);
}
else
{
  Console.WriteLine("number1=number2: " + number1);
}