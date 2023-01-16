/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

*/

void PrintArray(int[] array, Func<int, int, bool> format){
    Console.Write("[");
    for(int i=0;i< array.Length-1;i++){
        if (format(i,array[i])) 
            Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{array[i]}");
        Console.ResetColor();
        Console.Write(", ");
    }
    if (format(array.Length-1, array[array.Length-1])) 
        Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"{array[array.Length-1]}");
    Console.ResetColor();
    Console.WriteLine("]");
}

void PrintArrayD(double[] array, Func<int, double, bool> format){
    Console.Write("[");
    for(int i=0;i< array.Length-1;i++){
        if (format(i,array[i])) 
            Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{array[i]}");
        Console.ResetColor();
        Console.Write("; ");
    }
    if (format(array.Length-1, array[array.Length-1])) 
        Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"{array[array.Length-1]}");
    Console.ResetColor();
    Console.WriteLine("]");
}

int GetEvenCount(int[] array){
    int count = 0;
    for (int i=0; i < array.Length; i++){
        if(array[i]%2 == 0) count++;
    }
    return count;
}

int GetSumOfNotevenPos(int[] array){
    int sum = 0;
    for (int i=0; i < array.Length; i+=2){
        sum+=array[i];
    }
    return sum;
}




double[] GetMinMax(double[] array){
    double[] minmax = {array[0], array[0]};
    for(int i=0;i < array.Length; i++){
        if(array[i] < minmax[0]) minmax[0] = array[i];
        if(array[i] > minmax[1]) minmax[1] = array[i];
    }
    return minmax;
}


int[] CreateArray(int size, int min, int max, bool isRandom = true){
    int[] array = new int[size];

    Func<int, int> getNum;
    if (isRandom){
        Random rnd = new Random();
        getNum = i => {return rnd.Next(min,max);};
    } 
    else{
        getNum = i => {Console.Write($"Введите {i+1} элемент: "); return Convert.ToInt32(Console.ReadLine());};
    } 
    for(int i=0; i< size; i++){
        array[i] = getNum(i);
    }
    return array;
}


double[] CreateArrayD(int size, double min, double max, bool isRandom = true){
    double[] array = new double[size];

    Func<int, double> getNum;
    if (isRandom){
        Random rnd = new Random();
        getNum = i => {return rnd.NextDouble()* (max - min) + min;};
    } 
    else{
        getNum = i => {Console.Write($"Введите {i+1} элемент: "); return Convert.ToDouble(Console.ReadLine());};
    } 
    for(int i=0; i< size; i++){
        array[i] = getNum(i);
    }
    return array;
}


void task34(){
    Console.Write("Введите размер массива,а мы посчитаем число чётных элементов: ");
    int A = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(A, 100, 1000);
    Func<int,int, bool> format= (_,v) => v%2==0;
    PrintArray(array, format);
    Console.WriteLine($"Чётных элементов в массиве:{GetEvenCount(array)}");
}

void task36(){
    Console.Write("Введите размер массива, а мы найдём сумму элементов на нечётных позициях: ");
    int A = Convert.ToInt32(Console.ReadLine());
    //int[] array = CreateArray(A, int.MinValue, int.MaxValue);
    int[] array = CreateArray(A, -100, 101);
    Func<int,int, bool> format= (i,_) => i%2==0;
    PrintArray(array,format);
    Console.WriteLine($"Сумма: {GetSumOfNotevenPos(array)}");
}

void task38(){
    Console.Write("Введите размер массива, а мы найдём дельту элементов-экстремумов: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("заполнить случайными- 0, заполнить вручную- 1: ");
    bool isRandom = Convert.ToInt32(Console.ReadLine()) == 0;
    double[] array = CreateArrayD(A, -100.0, 101.0, isRandom);
    double[] minmax = GetMinMax(array);
    Func<int,double, bool> format= (i,v) => v==minmax[0] || v== minmax[1];
    PrintArrayD(array,format);
    Console.WriteLine($"Разность между элементами: {minmax[1] - minmax[0]}");
}

task34();
task36();
task38();