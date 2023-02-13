/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

int [,] Generate2DArray(int N, int M){
    int[,] array = new int[N,M];
    Random rand = new Random();

    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            array[i,j] = rand.Next(0,5);
        }
    }

    return array;
}

int [,,] Generate3DArray(int N, int M, int B){
    int[,,] array = new int[N,M,B];
    Random rand = new Random();
    if ( N*M*B > 99){
        throw(new SystemException("Ошибка размерности!"));
    }
    //int maxValue = N*M*B;
    int [] unique_values = new int [N*M*B];
    int ui = 0;
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            for(int k=0; k<array.GetLength(1); k++){
                int value = 0;// = rand.Next(10,99);
                bool is_uniq = true;
                
                do{
                    is_uniq = true;
                    value = rand.Next(10,99);
                    for (int c=0; c< unique_values.Length; c++){
                        if(unique_values[c] == value){
                            /*Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{value}\t"); //дебаг повторов генерации
                            Console.ResetColor();*/
                            is_uniq = false;
                            break;
                        }
                    }
                }while(!is_uniq);
                unique_values[ui] = value;
                ui++;
                array[i,j,k] = value;
                //Console.Write($"{value}\t");
            }
        }
    }

    return array;
}

void PrintLayersArray(int [,,] array){
    for(int i=0; i<array.GetLength(0); i++){
        Console.WriteLine($"Layer №{i}:");
        for(int j=0; j<array.GetLength(1);j++){
            for(int k=0; k<array.GetLength(1);k++)
                Console.Write($"{array[i,j,k]}\t");
            Console.Write("\n");
        }
    }
}


void PrintArray(int [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1);j++){
            Console.Write($"{array[i,j]}\t");
        }
        Console.Write("\n");
    }
}

void task54(){
    int N=4, M=4;
    var array = Generate2DArray(N,M);
    PrintArray(array);
    for (int i=0; i < N; i++){
        for(int k=0; k<M-1; k++){
            int max_j = k; //array[i,0];
            for(int j=k+1; j<M;j++){
                if(array[i, max_j] < array[i, j]){
                    max_j = j;
                }
            }
            var temp = array[i, k];
            array[i, k] = array[i, max_j];
            array[i,max_j] = temp;
        }
    }
    Console.WriteLine("Sorted:");
    PrintArray(array);
}


//task54();

void task56(){
    int N = 4, M = 5;
    var array = Generate2DArray(N,M);

    int best_row = 0;
    int best_summ = 0;
    for(int j=0; j< array.GetLength(1); j++){
            best_summ += array[0,j];
    }

    for (int i=0; i< array.GetLength(0); i++){
        int summ = 0;
        for(int j=0; j< array.GetLength(1); j++){
            Console.Write($"{array[i,j]}\t");
            summ += array[i,j];
        }
        if(summ < best_summ){
            best_row = i;
            best_summ = summ;
        }
        Console.WriteLine($"|sum={summ}");

    }
    
    Console.WriteLine($"Best row with minimal summ is green:");

    for(int i=0; i<array.GetLength(0); i++){
        if(i == best_row){
            Console.ForegroundColor = ConsoleColor.Green;
        }else{
            Console.ResetColor();
        }
        for(int j=0; j<array.GetLength(1);j++){
            Console.Write($"{array[i,j]}\t");
        }
        Console.Write("\n");
    }
}

//task56();

void task58(){
    int N=2, M=2;
    var array1 = Generate2DArray(N,M);
    var array2 = Generate2DArray(N,M);
    int [,] result = new int[N, M];

     for (int i = 0; i < N; i++) 
        for (int j = 0; j < M; j++)
            for (int k = 0; k < M; k++)           
                result[i,j] += array1[i,k] * array2[k,j];    

    Console.WriteLine("First array:");
    PrintArray(array1);

    
    Console.WriteLine("Second array:");
    PrintArray(array2);

    
    Console.WriteLine("Result array:");
    PrintArray(result);

}

//task58();


void task60(){
    var array = Generate3DArray(3,3,3);
    //послойный вывод:
    Console.WriteLine("my interpretation of print method");
    PrintLayersArray(array);



    //построчный вывод с индексами:
    Console.WriteLine("other print method");
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1);j++){
            for(int k=0; k<array.GetLength(1);k++){
                Console.WriteLine($"{array[i,j,k]}({i},{j},{k})");
            }
        }
    }
    
}

//task60();


void task62(){
    int N = 5;
    int [,] array = new int[N,N];
    Console.Write("выберите направление 0-почасовой, 1-противчасовой:");
    bool orient = Console.ReadLine() == "0";
    int i_start = 0; 
    int i_end = 0; 
    int  j_start = 0; 
    int  j_end = 0;
    
    int k = 0, i=0, j=0;

    while (k < N * N){

        if(orient){
            array[i,j] = k++;
        }else{
            array[j,i] = k++;
        }

        if (i == i_start && j < N - 1 - j_end)
            ++j;
        else if (j == N - 1 - j_end && i < N - 1 - i_end)
            ++i;
        else if (i == N - 1 - i_end && j > j_start)
            --j;
        else
            --i;

        if ((i == i_start + 1) && (j == j_start) && (j_start != N - 1 - j_end)){
            i_start++;
            i_end++;
            j_start++;
            j_end++;
        }
    }
    
    PrintArray(array);

}

task62();