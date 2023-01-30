/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrintArray(double [,] arr){

    for(int i=0; i< arr.GetLength(0);i++){
        for(int j=0; j<arr.GetLength(1);j++){
            Console.Write($"{arr[i,j]:##.##}\t"); //= rand.NextDouble()*100 - 50;
        }
        Console.Write("\n");
    }
}

void PrintArrayInt(int [,] arr){

    for(int i=0; i< arr.GetLength(0);i++){
        for(int j=0; j<arr.GetLength(1);j++){
            Console.Write($"{arr[i,j]}\t"); //= rand.NextDouble()*100 - 50;
        }
        Console.Write("\n");
    }
}

double[,] GenerateArray(int m, int n){
    double [,] arr = new double [m,n];
    Random rand = new Random();

    for(int i=0; i< n;i++){
        for(int j=0; j<m;j++){
            arr[j,i]= rand.NextDouble()*100 - 50;
        }
    }
    return arr;
}

int[,] GenerateArrayInt(int m, int n){
    int [,] arr = new int [m,n];
    Random rand = new Random();

    for(int i=0; i< n;i++){
        for(int j=0; j<m;j++){
            arr[j,i]= rand.Next() % 100 - 50;
        }
    }
    return arr;
}

void task47(){
    Console.Write("Введите кол-во строк: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите кол-во столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double [,] arr = GenerateArray(m,n);
    
    PrintArray(arr);
}

void task50(){

    int n=10, m=10;
    double [,] arr = GenerateArray(m,n);

    PrintArray(arr);

    Console.Write("Введите целевую строку: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите целевой столбец: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if( x < 0 || y < 0 || x > n || y > m){
        Console.WriteLine("Введите позицию более 0 и не более 10!");
        return;
    }

    Console.WriteLine($"Значение массива в точке arr({x};{y}) = {arr[x-1,y-1]:##.##}");
}


void task52(){

    int [,] arr = GenerateArrayInt(3, 4);

    PrintArrayInt(arr);
    for(int j =0; j< arr.GetLength(1); j++){
        int sum = 0;
        for(int i =0; i< arr.GetLength(0); i++){
            sum += arr[i,j];
        }
        Console.ForegroundColor =ConsoleColor.Blue;
        Console.Write($"{sum/arr.GetLength(0)}\t");
        Console.ResetColor();
    }
}



//task47();
//task50();
task52();
