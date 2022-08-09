// Задача №34:Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача №34");
Console.Write("Введи размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
FillArrayRandomNumbers(arr);
int PositiveNumber = 0;
for(int i=0;i<arr.Length;i++){                      
    if(arr[i] % 2 == 0)
    PositiveNumber = PositiveNumber+ 1;}  
void FillArrayRandomNumbers(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(100,1000);}}
Console.WriteLine("полученный массив: "+'['+string.Join(",", arr)+']');
Console.WriteLine($"количество чётных чисел в массиве = {PositiveNumber}");