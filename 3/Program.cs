﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



int Enter_number(string message){

Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());

}

int number = Enter_number("Введите число : ");

for (int i= 1; i <= number; i++){
    Console.Write($"{i*i*i}");
}