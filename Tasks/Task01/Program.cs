//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
///12821 -> да
//23432 -> да


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string copy = number.ToString();
Console.WriteLine(CheckingNumber(copy));

string CheckingNumber(string number)
{
  string copy = "";
  for (int i = number.Length - 1; i >= 0; i--)
  {
    copy += number[i];
  }
  return copy; 
}
string result = CheckingNumber(copy);

if(result == copy)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");
}
