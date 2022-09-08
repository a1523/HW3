// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

string Polindrom(string number) 
{
if (number.Length >= 6) 
    {
    return "Ошибка! Введите пятизначное число!";
    }
if (number[0] == number[4] && number[2] == number[3]) 
    {
    return "Число является полиндромом";
    }
return "Число не является полиндромом";
}

Console.WriteLine("Введите пятизначное число: ");
string number = Convert.ToString(Console.ReadLine());
string numberP = Polindrom(number);
Console.WriteLine(numberP);
