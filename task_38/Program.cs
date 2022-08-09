// Задача №38:Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76

Console.WriteLine("Задача №38");
Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[size];
for (int i = 0; i < arr.Length; i++ ){
    arr[i] = new Random().Next(1, 10);}
double maxNumber = arr[0];
double minNumber = arr[0];
for (int j = 0; j < arr.Length; j++){
    if (maxNumber < arr[j]){
        maxNumber = arr[j];}
    if (minNumber > arr[j]){
        minNumber = arr[j];}}
double result = maxNumber - minNumber; 
Console.WriteLine("Полученный массив : "+'['+string.Join(",", arr)+']');
Console.WriteLine($"Минимальный элемент массива = {minNumber} ");
Console.WriteLine($"Максимальный элемент массива = {maxNumber} ");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");