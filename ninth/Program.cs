/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

bool isSimple(int start, int value = -1){
    if(value == -1) value = start-1;
    if (value <= 1) return true;
    if (start % value != 0) return isSimple(start, value-1);
    else return false;
}
var end = "\n";
var empty = "";

int Akkermann(int first, int second){
    if(first==0) return second+1;
    if (second==0) return Akkermann(first-1, 1);
    return Akkermann(first-1, Akkermann(first,second-1));    
}

void task64(){
    Console.Write("Insert N for find all simple numeric between N to 1 ::");
    int N = Convert.ToInt32(Console.ReadLine());
    for(int i=N; i>0;i--) {
        if(isSimple(i)) Console.WriteLine($"{i}");
    }
}
int RecursiveSum(int value, int stop = 0, int summ = 0){
    if (value == stop) return summ+value;
    else return RecursiveSum(value-1, stop, summ+value);
//    Console.WriteLine($"{value} | {summ}");
}
//task64();
void task66(){
    int N, M;
    Console.Write("Insert N :");
    N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert M :");
    M = Convert.ToInt32(Console.ReadLine());

    int begin = N<M?M:N;
    int finish = N>M?M:N;
    Console.WriteLine($"{begin} | {finish}");

    Console.WriteLine($"{RecursiveSum(begin, finish)}");
}
//task66();
void task68(){
    int N, M;
    Console.Write("Insert M :");
    M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert N :");
    N = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{Akkermann(M,N)}");
}

task68();