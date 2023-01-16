/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/
void PrintArray(int[] array){
    Console.Write("[");
    for(int i=0;i< array.Length-1;i++)
        Console.Write($"{array[i]},");
    Console.WriteLine($"{array[array.Length-1]}]");
}

void task25(){
    Console.Write("Введите основание степени: ");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите степень:");
    int B = Convert.ToInt32(Console.ReadLine());

    int res = A;
    if (B>1){
        for(int i=2; i<=B; i++){
            res = res*A;
        }
    }else if(B == 0){
        res = 1;
    }else if (B< 1){
        Console.WriteLine($"{A}^{B} = ошибка, речь о натуральной степени!!!");
        return;
    }
    
    Console.WriteLine($"{A}^{B} = {res}");
}


void task27(){
    Console.Write("Введите число, а мы посчитаем сумму цифр: ");
    int A = Convert.ToInt32(Console.ReadLine());
    A = Math.Abs(A);
    int sum = 0;
    for(int i = A; i!= 0; i/=10){
        sum += i%10;
    }
    Console.WriteLine($"Сумма цифр:{sum}");
}

void task29(){
    Console.Write("Введите размер будующего массива: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[M];
    for(int i=0; i<M;i++){
        Console.Write($"введите значение для элемента {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    PrintArray(array);
}

task25();
task27();
task29();