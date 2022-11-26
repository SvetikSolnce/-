//Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] arr1 = new string[6] {"1", "2", "result", "):", "hello", "start"};
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

