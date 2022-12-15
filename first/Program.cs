/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int a = -1;
string yes = "да";
string no = "нет";

while(a != 0){
    Console.Write("Введите номер задачи 2,4,6,8, выход из программы 0: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 0) break;
    switch (a){
        case 2:
            Console.Write("Поиск максимума из двух чисел, введите первое число: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Максимум {(n1>n2?n1:n2)}, минимум: {(n1>n2?n2:n1)}");
            break;
        case 4:
            Console.Write("Поиск максимума из трёх чисел, введите первое число: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите третье число: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Максимум {(n1>n2 ? (n1>n3)?n1:n3 : (n2>n3)?n2:n3)}");
            break;
        case 6:
            Console.Write("Проверка чётности, введите число: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1%2 == 0 ? yes : no);
            break;
        case 8:
            Console.Write("Поиск чётных от 1 до N, введите число N: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 < 1){
                Console.WriteLine("пусто...");
            }else{
                if (n1%2==0) n1++;
                for(int i = 2; i<n1;i+=2){
                    Console.Write(i + " ");
                }
            }
            break;
    }
    Console.WriteLine("\n--------------------------------------------------\n\n");
}