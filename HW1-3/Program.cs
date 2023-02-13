Console.Clear();

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
bool evenNumber = true;
if (number % 2 == 0)
{
  Console.WriteLine("Число четное: " + evenNumber);
}
else
{
  Console.WriteLine("Число четное: " + !evenNumber);
}