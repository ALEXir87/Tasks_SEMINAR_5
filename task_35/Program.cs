// Задача №35:Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5 элементов :
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Задача №35");
int[] arr = new int[123];
FillArrayRandomNumbers(arr);
int element = 0;
for(int i=0;i<arr.Length;i++){                      
    if(arr[i] > 9 && arr[i] < 100)
    element = element + 1;}  
void FillArrayRandomNumbers(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(0,1000);}}
Console.WriteLine('['+string.Join(",", arr)+']');
Console.WriteLine($"количество элементов массива в отрезке [10,99] = {element}");