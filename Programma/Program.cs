﻿//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
Console.WriteLine("Введите массив строк через пробел");
string[] arr1 = Console.ReadLine().Split(' ');
string[] arr2 = new string[arr1.Length];
void Massiv (string[] arr1, string[] arr2) {
     int count = 0;
     for (int i=0; i<arr1.Length; i++) {
        if(arr1[i].Length <= 3) {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
Massiv(arr1, arr2);
Console.WriteLine(String.Join(" ", arr2));

