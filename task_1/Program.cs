// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using System;
void zadacha19()
{
    Console.Write("Введите пятизначное число:");
    string number = Console.ReadLine();
    string new_number = "";
    if (number.Length == 5)
    {
        for (int i = 4; i >= 0; i --)
        {
            new_number += number[i];
        }
        if (new_number == number)
        {
            Console.Write("Это полиндром");
        }
        else
        {
            Console.Write("Это не полиндром");
        }

    }
    else
    {
        Console.Write("Число не пятизначное,\n\rПезапуститое программу!!!");
    }

    
    
    
    // for (int i = 4; i >= 0; i --)
    // {
    //     Console.Write(number[i]);
    // }
        
      
    
   
 
    

}

zadacha19();


