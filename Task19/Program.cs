// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  14212 -> нет
//  12821 -> да
//  23432 -> да

Console.WriteLine("Введите пятизначное число:  ");
int a = Convert.ToInt32(Console.ReadLine());
int index = 10000;
bool Check = false;
while(a > 0)
{
    index = a / index;
    a = a % 10;
    
  if(index == a%10)
  {
    Check = true;
  }
   else Check = false;
    index /= 10;
    a /= 10;
}
if(Check)
Console.WriteLine("Число  является палиндромом"); 
else Console.WriteLine("Число   не является палиндромом");