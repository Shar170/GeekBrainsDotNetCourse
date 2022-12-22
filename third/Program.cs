/*
    Задача 19
    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да

    Задача 21
    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53

    Задача 23
    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/

bool isPalindrom(int num){
    int n_count = (int)Math.Ceiling(Math.Log10(Math.Abs(num)));
    int counter = 1;
    while(counter <= n_count/2){
        int head = num / (int)Math.Pow(10, n_count - counter);
        if (counter > 1) head%= 10;
        int tail = num % (int)Math.Pow(10, counter) / (int)Math.Pow(10, counter - 1);
        //Console.WriteLine($"{head} and {tail}");
        if (head != tail) return false;
        counter++;
    }
    return true;
}

double GetLenght(double x1, double y1, double z1, double x2, double y2, double z2){
    double x = x1-x2;
    double y = y1-y2;
    double z = z1-z2;
    return Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2));
}

void PrintCubes(int num){
    Console.WriteLine("x\t|\tx^3");
    for(int i=1; i<=num; i++){
        Console.WriteLine($"{i}\t|\t{Math.Pow(i,3)}");
    }
}

int a = -1;
while(a != 0){
    Console.Write("Введите номер задачи 19,21,23 выход из программы 0: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (a == 0) break;
    int n1;
    Console.ForegroundColor = ConsoleColor.Blue;
    switch (a){
        case 19:
            Console.Write("Введите для опеределения, является ли оно полиндромом: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPalindrom(n1));
            break;
        case 21:
            Console.WriteLine("Нахождение расстояния между точками в трёх мерном пространстве, введите координаты");
            Console.WriteLine("input x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input z1:");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input z2:");
            double z2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A[{x1},{y1},{z1}] B[{x2},{y2},{z2}] lenght of AB is {GetLenght(x1,y1,z1,x2,y2,z2)}");
            break;
        case 23:
            Console.Write("Введите N, для вывода кубов чисел от 1 до N: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            PrintCubes(n1);
            break;
    }
    Console.ResetColor();
}
