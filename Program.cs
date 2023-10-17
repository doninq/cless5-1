/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
//using System.CodeDom.Compiler;

int[] GenerateArroy(int n)
{
    int[] Arr = new int[n];
    for(int i = 0; i < n; i++)
    {
       Arr[i] = new Random().Next(99, 999);
    }
    return Arr;
}

void PrintArray(int[] Arr)
    {
    Console.Write("[ ");  
    
    for (int i = 0; i < Arr.Length; i++)
    {
    Console.Write(Arr[i] + " ");        
    }
    Console.Write("]");  
    }

int ChetnArray(int[] Arr)
{ int Ch = 0;
  for (int i = 0; i < Arr.Length; i++)
    {
    if ((Arr[i] % 2) == 0)  Ch++;     
    } 
    return Ch;
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int[] Arr = GenerateArroy(n);
PrintArray(Arr);
Console.WriteLine(""); 
Console.Write("Количество четных чисел:" + ChetnArray(Arr)); 
