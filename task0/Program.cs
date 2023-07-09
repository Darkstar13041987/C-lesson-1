// Напишите программу, которая на вход 
// принимает число и выдаёт его квадрат (число 
// умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// int- числовая переменная (когда работаем с числами)
// int number = Console.ReadLine ();   //запрашиваем число у пользователя первое действие
Console.WriteLine("Ведите число :"); //подсказка для пользователя
// int number = int.Parse( Console.ReadLine());    //Parse переводит из строки в число
// Console.WriteLine(number * number);            

// водим новую переменную result
//Console.WriteLine("Ведите число :"); //подсказка для пользователя
int number = int.Parse( Console.ReadLine());    //Parse переводит из строки в число,Console.ReadLine() считывает с console
int result = number * number;          // новая переменная результат для number * number

Console.WriteLine("квадрат числа = " + result);         //запрашиваем вывести  result = number * number   склеиваем строку через + сообщение в ковычках и результат
