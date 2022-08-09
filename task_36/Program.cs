// Задача №36:Задайте одномерный массив,заполненный случайными числами.Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача №36");
Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
FillArrayRandomNumbers(arr);
int SumOddNumber = 0;
for(int i=0;i<arr.Length;i++){ 
    if(i % 2 == 1){                   
        SumOddNumber = SumOddNumber + arr[i];}} 
void FillArrayRandomNumbers(int[] arr){
    for(int j = 0; j < arr.Length; j++){
        arr[j] = new Random().Next(-10,10);}}
Console.WriteLine("полученный массив : "+'['+string.Join(",", arr)+']');
Console.WriteLine($"сумма нечётных элементов массива = {SumOddNumber}");